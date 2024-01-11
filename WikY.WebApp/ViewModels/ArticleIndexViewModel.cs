using WikY.WebApp.Models;

namespace WikY.WebApp.ViewModels;

public class ArticleIndexViewModel
{
    public string? Message { get; set; }

    public ArticleModel Article { get; set; } = null!;
}
