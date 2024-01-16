using Microsoft.AspNetCore.Mvc;
using WikY.Business.Articles.Create;
using WikY.Business.Articles.Delete;
using WikY.Business.Articles.Find;
using WikY.Business.Articles.FindById;
using WikY.Business.Articles.IsTitleUnique;
using WikY.Business.Articles.Update;
using WikY.Business.Authors.GetAll;
using WikY.Business.Comments.GetByArticleId;
using WikY.Business.Contracts.Common;
using WikY.Entities.Articles;
using WikY.Entities.Authors;
using WikY.Entities.Comments;
using WikY.WebApp.Mappers;
using WikY.WebApp.Models;
using WikY.WebApp.ViewModels;

namespace WikY.WebApp.Controllers;

public class ArticleController(ArticleMapper mapper) : Controller
{
    private readonly ArticleMapper _mapper = mapper;

    public async Task<IActionResult> Index(
        [FromServices] IQuerySearcherHandler<FindArticlesQuery, List<Article>, int> handler,
        string? message)
    {
        var query = new FindArticlesQuery(Count: 1);

        var article = (await handler.Search(query)).FirstOrDefault();

        return View(new ArticleIndexViewModel { Message = message, Article = article is null ? null : _mapper.Map(article) });
    }

    [HttpGet]
    public async Task<IActionResult> Create(
        [FromServices] IQueryHandler<GetAllAuthorsQuery, List<Author>> handler,
        [FromServices] AuthorMapper authorMapper,
        ArticleDto? articleDto = null
        )
    {
        var authors = await handler.Handle(new GetAllAuthorsQuery());
        var authorDtos = authors.Select(authorMapper.Map).ToList();

        var createArticleModel = new CreateArticleViewModel { Article = articleDto ?? new ArticleDto(), Authors = authorDtos};
        return View(createArticleModel);
    }

    [HttpPost]
    public async Task<IActionResult> Create(
        [FromServices] IQueryHandler<GetAllAuthorsQuery, List<Author>> getAllAuthorsHandler,
        [FromServices] ICommandHandler<CreateArticleCommand, Article> createArticleHandler,
        [FromServices] AuthorMapper authorMapper,
        CreateArticleViewModel createArticleModel)
    {
        if (ModelState.IsValid)
        {
            var command = new CreateArticleCommand(createArticleModel.Article.Title, createArticleModel.Article.Content, createArticleModel.Article.AuthorId);

            var article = await createArticleHandler.Handle(command);

            createArticleModel.Article = _mapper.Map(article);

            return RedirectToAction(nameof(Index));
        }

        var authors = await getAllAuthorsHandler.Handle(new GetAllAuthorsQuery());
        var authorDtos = authors.Select(authorMapper.Map).ToList();
        createArticleModel.Authors = authorDtos;

        return View("Create", createArticleModel);
    }

    public async Task<IActionResult> IsTitleUnique(
        string title,
        [FromServices] IQueryHandler<IsTitleUniqueQuery, bool> handler)
    {
        var query = new IsTitleUniqueQuery(title);

        bool res = await handler.Handle(query);

        return Json(!res);
    }

    [HttpGet]
    public async Task<IActionResult> Details(
        [FromServices] IQueryHandler<FindArticleByIdQuery, Article?> findArticleHandler,
        [FromServices] IQueryHandler<GetCommentsByArticleIdQuery, List<Comment>> getCommentsByArticleIdHandler,
        [FromServices] CommentMapper commentMapper,
        string id)
    {
        var query = new FindArticleByIdQuery(id);

        var article = await findArticleHandler.Handle(query);
        var comments = await getCommentsByArticleIdHandler.Handle(new GetCommentsByArticleIdQuery(id));

        if (article is null)
            return RedirectToAction(nameof(Index));

        var articleDto = _mapper.Map(article);
        var commentDtos = comments.Select(commentMapper.Map).ToList();

        return View(new ArticleDetailsViewModel { Article = articleDto, Comments = commentDtos });
    }

    [HttpGet]
    public async Task<IActionResult> List(
        [FromServices] IQuerySearcherHandler<FindArticlesQuery, List<Article>, int> handler,
        int? page
        )
    {
        var query = new FindArticlesQuery(Page: page, Count: 20);

        var articles = await handler.Search(query);
        var articleDtos = articles.Select(_mapper.Map).ToList();

        return View(articleDtos);
    }

    [HttpPost]
    public async Task<IActionResult> ListFiltered(
        [FromServices] IQuerySearcherHandler<FindArticlesQuery, List<Article>, int> handler,
        string searchString,
        string order,
        bool isAscending = true
        )
    {
        ArticleProperties orderByArticleProperty = order switch
        {
            "CreationDate" => ArticleProperties.CreationDate,
            "UpdatedDate" => ArticleProperties.UpdatedDate,
            "Title" => ArticleProperties.Title,
            "Content" => ArticleProperties.Content,
            "AuthorName" => ArticleProperties.AuthorName,
            _ => ArticleProperties.CreationDate,
        };

        var query = new FindArticlesQuery(
            SearchString: searchString,
            OrderBy: orderByArticleProperty,
            Direction: isAscending? OrderByDirection.Ascending : OrderByDirection.Descending
            );

        var articles = await handler.Search(query);
        var articleDtos = articles.Select(_mapper.Map).ToList();

        return PartialView("_ArticleList", articleDtos);
    }

    [HttpGet]
    public async Task<IActionResult> CountArticles(
        [FromServices] IQuerySearcherHandler<FindArticlesQuery, List<Article>, int> handler
        )
    {
        var count = await handler.Count(new FindArticlesQuery());

        return Json(count);
    }

    public async Task<IActionResult> Delete(
        [FromServices] ICommandHandler<DeleteArticleCommand, bool> handler,
        [FromRoute] string id)
    {
        var command = new DeleteArticleCommand(id);

        var isDeleted = await handler.Handle(command);

        if (isDeleted)
            return RedirectToAction(nameof(Index), new { message = "Article bien supprimé" });

        return RedirectToAction(nameof(Index), new { message = "Article non suppprimé" });
    }

    [HttpGet]
    public async Task<IActionResult> Edit(
        [FromServices] IQueryHandler<FindArticleByIdQuery, Article?> handler,
        string id
        )
    {
        var article =  await handler.Handle(new FindArticleByIdQuery(id));

        if (article is null)
            return RedirectToAction(nameof(Index), new { message = "Article invalide" });

        var articleDto = _mapper.Map(article);
        return View(articleDto);
    }

    [HttpPost]
    public async Task<IActionResult> Edit(
        [FromServices] ICommandHandler<UpdateArticleCommand, Article?> handler,
        ArticleDto articleDto)
    {
        if (ModelState.IsValid)
        {
            var command = new UpdateArticleCommand(articleDto.Id, articleDto.Title, articleDto.Content);

            await handler.Handle(command);

            return RedirectToAction(nameof(Index));
        }

        return View(articleDto);
    }
}
