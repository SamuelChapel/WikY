using WikY.WebApp.Models;

namespace WikY.WebApp.ViewModels;

public class CreateArticleViewModel
{
    public ArticleModel Article { get; set; } = null!;
    public List<AuthorModel> Authors { get; set; } = null!;
}
