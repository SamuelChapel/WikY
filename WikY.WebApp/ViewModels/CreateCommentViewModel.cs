using WikY.WebApp.Models;

namespace WikY.WebApp.ViewModels;

public class CreateCommentViewModel
{
    public CommentDto Comment { get; set; } = null!;

    public List<AuthorDto> Authors { get; set; } = null!;
}
