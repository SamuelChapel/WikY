using WikY.WebApp.Models;

namespace WikY.WebApp.ViewModels;

public class ArticleDetailsViewModel
{
    public ArticleDto Article { get; set; } = null!;

    public List<CommentDto> Comments { get; set; } = null!;
}
