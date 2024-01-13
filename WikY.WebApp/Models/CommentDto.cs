namespace WikY.WebApp.Models;

public class CommentDto
{
    public string Id { get; set; } = null!;
    public string Content { get; set; } = null!;
    public string ArticleId { get; set; } = null!;
    public string AuthorId { get; set; } = null!;
    public string Author { get; set; } = null!;

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
