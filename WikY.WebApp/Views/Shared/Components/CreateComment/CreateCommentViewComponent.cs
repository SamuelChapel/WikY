using Microsoft.AspNetCore.Mvc;
using WikY.Business.Authors.GetAll;
using WikY.Business.Contracts.Common;
using WikY.Entities.Authors;
using WikY.WebApp.Mappers;
using WikY.WebApp.Models;
using WikY.WebApp.ViewModels;

namespace WikY.WebApp.Views.Shared.Components.CreateComment;

public class CreateCommentViewComponent(
    IQueryHandler<GetAllAuthorsQuery, List<Author>> handler,
    AuthorMapper mapper
    ) : ViewComponent
{
    private readonly IQueryHandler<GetAllAuthorsQuery, List<Author>> _handler = handler;
    private readonly AuthorMapper _mapper = mapper;

    public async Task<IViewComponentResult> InvokeAsync(string articleId, bool ajax = false)
    {
        var authors = await _handler.Handle(new GetAllAuthorsQuery());
        var authorDtos = authors.Select(_mapper.Map).ToList();

        if (ajax)
            return View("Ajax", authorDtos);

        var createCommentViewModel = new CreateCommentViewModel { Authors = authorDtos, Comment = new CommentDto() { ArticleId = articleId } };

        return View("Default", createCommentViewModel);
    }
}
