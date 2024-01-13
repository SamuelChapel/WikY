using WikY.WebApp.Models;

namespace WikY.WebApp.ViewModels;

public class CreateArticleViewModel
{
    public ArticleDto Article { get; set; } = null!;
    public List<AuthorDto> Authors { get; set; } = null!;
}
