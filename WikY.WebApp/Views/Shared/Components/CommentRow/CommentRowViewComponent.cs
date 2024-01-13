using Microsoft.AspNetCore.Mvc;
using WikY.WebApp.Models;

namespace WikY.WebApp.Views.Shared.Components.CommentRow;

public class CommentRowViewComponent : ViewComponent
{
    public IViewComponentResult Invoke(string articleId, CommentDto comment)
    {
        return View((articleId, comment));
    }
}
