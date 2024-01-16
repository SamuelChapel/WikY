using WikY.WebApp.Models;

namespace WikY.WebApp.ViewModels;

public class ArticlesListViewModel
{
    public List<ArticleDto> ArticleDtos { get; set; } = null!;

    public int Count { get; set; } = 0;
}
