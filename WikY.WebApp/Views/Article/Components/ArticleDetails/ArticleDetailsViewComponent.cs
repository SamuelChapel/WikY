using Microsoft.AspNetCore.Mvc;
using WikY.WebApp.Models;

namespace WikY.WebApp.Views.Article.Components.ArticleDetails;

public class ArticleDetailsViewComponent : ViewComponent
{
    public IViewComponentResult Invoke(ArticleModel article, bool showDetailBtn)
    {
        return View((article, showDetailBtn));
    }
}
