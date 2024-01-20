using System.ComponentModel.DataAnnotations;

namespace WikY.WebApp.Models;

public class CommentDto
{
    public string? Id { get; set; } = null!;

    [Required]
    [StringLength(100)]
    public string Content { get; set; } = null!;

    [Required]
    public string ArticleId { get; set; } = null!;

    [Required]
    public string AuthorId { get; set; } = null!;
    public string? Author { get; set; } = null!;

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
