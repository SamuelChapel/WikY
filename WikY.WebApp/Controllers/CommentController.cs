using Microsoft.AspNetCore.Mvc;
using WikY.Business.Comments.Create;
using WikY.Business.Comments.Delete;
using WikY.Business.Contracts.Common;
using WikY.Entities.Comments;
using WikY.WebApp.Mappers;
using WikY.WebApp.Models;
using WikY.WebApp.ViewModels;

namespace WikY.WebApp.Controllers;

public class CommentController : Controller
{
    [HttpGet]
    public IActionResult Create(string id)
    {
        return View("Create", id);
    }

    [HttpPost]
    public async Task<IActionResult> Create(
        [FromServices] ICommandHandler<CreateCommentCommand, Comment?> handler,
        CreateCommentViewModel createCommentViewModel
        )
    {
        if (ModelState.IsValid)
        {
            await handler.Handle(new CreateCommentCommand(createCommentViewModel.Comment.ArticleId, createCommentViewModel.Comment.AuthorId, createCommentViewModel.Comment.Content));

            return RedirectToAction("Details", "Article", new { id = createCommentViewModel.Comment.ArticleId });
        }

        return View(createCommentViewModel);
    }

    [HttpPost]
    public async Task<IActionResult> CreateAjax(
        [FromServices] ICommandHandler<CreateCommentCommand, Comment?> handler,
        [FromServices] CommentMapper mapper,
        string articleId,
        string content,
        string authorId
        )
    {
        var command = new CreateCommentCommand(articleId, authorId, content);

        if (await handler.Handle(command) is Comment c)
        {
            CommentDto comment = mapper.Map(c);

            return ViewComponent("CommentRow", new { articleId, comment });
        }

        return Json(false);
    }

    [HttpPost]
    public async Task<IActionResult> Delete(
        [FromServices] ICommandHandler<DeleteCommentCommand, bool> handler,
        string articleId,
        string commentId
        )
    {
        var command = new DeleteCommentCommand(commentId);

        await handler.Handle(command);

        return RedirectToAction("Details", "Article", new { id = articleId });
    }

    [HttpPost]
    public async Task<IActionResult> DeleteAjax(
        [FromServices] ICommandHandler<DeleteCommentCommand, bool> handler,
        string commentId)
    {
        var command = new DeleteCommentCommand(commentId);

        return Json(await handler.Handle(command));
    }
}
