using Microsoft.AspNetCore.Mvc;
using WikY.Business.Articles.Create;
using WikY.Business.Articles.Find;
using WikY.Business.Articles.FindById;
using WikY.Business.Articles.IsTitleUnique;
using WikY.Business.Authors.GetAll;
using WikY.Business.Contracts.Common;
using WikY.Entities.Articles;
using WikY.Entities.Authors;
using WikY.WebApp.Mappers;
using WikY.WebApp.Models;
using WikY.WebApp.ViewModels;

namespace WikY.WebApp.Controllers;

public class ArticleController : Controller
{
    private readonly ArticleMapper _mapper;

    public ArticleController(ArticleMapper mapper) => _mapper = mapper;

    public async Task<IActionResult> Index(
        [FromServices] IQueryHandler<FindArticlesQuery, List<Article>> handler,
        string? message)
    {
        var query = new FindArticlesQuery(Count: 1);
        ;

        var articles = await handler.Handle(query);
        var articleModel = _mapper.Map(articles.First());

        return View(new ArticleIndexViewModel { Message = message, Article = articleModel });
    }

    [HttpGet]
    public async Task<IActionResult> Create(
        [FromServices] IQueryHandler<GetAllAuthorsQuery, List<Author>> handler,
        [FromServices] AuthorMapper authorMapper
        )
    {
        var authors = await handler.Handle(new GetAllAuthorsQuery());
        var authorModels = authors.Select(authorMapper.Map).ToList();
        var createArticleModel = new CreateArticleViewModel { Article = new ArticleModel(), Authors = authorModels};
        return View(createArticleModel);
    }

    [HttpPost]
    public async Task<IActionResult> Create(
        [FromServices] ICommandHandler<CreateArticleCommand, Article> handler,
        CreateArticleViewModel createArticleModel)
    {
        var command = new CreateArticleCommand(createArticleModel.Article.Title, createArticleModel.Article.Content, createArticleModel.Article.AuthorId);

        var article = await handler.Handle(command);

        createArticleModel.Article = _mapper.Map(article);

        return RedirectToAction(nameof(Index));
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
        [FromServices] IQueryHandler<FindArticleByIdQuery, Article?> handler,
        string id)
    {
        var query = new FindArticleByIdQuery(id);

        var article = await handler.Handle(query);

        if (article is null)
            return RedirectToAction(nameof(NotFound));

        var articleModel = _mapper.Map(article);

        return View(articleModel);
    }

    [HttpGet]
    public async Task<IActionResult> List(
        [FromServices] IQueryHandler<FindArticlesQuery, List<Article>> handler,
        int? page
        )
    {
        var query = new FindArticlesQuery(Page: page);

        var articles = await handler.Handle(query);
        var articlesModel = articles.Select(_mapper.Map).ToList();

        return View(articlesModel);
    }
}
