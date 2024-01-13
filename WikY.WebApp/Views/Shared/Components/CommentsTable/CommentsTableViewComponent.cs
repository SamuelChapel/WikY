using Microsoft.AspNetCore.Mvc;
using WikY.WebApp.Models;

namespace WikY.WebApp.Views.Shared.Components.CommentsTable;

public class CommentsTableViewComponent : ViewComponent
{
    public IViewComponentResult Invoke(string articleId, List<CommentDto> comments)
    {
        return View((articleId, comments));
    }
}
