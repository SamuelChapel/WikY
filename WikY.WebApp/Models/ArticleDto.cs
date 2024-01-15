using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using WikY.Entities.Comments;

namespace WikY.WebApp.Models;

public class ArticleDto
{
    public string Id { get; set; } = null!;

    [Required(ErrorMessage = "Le titre doit être rempli")]
    [Remote("IsTitleUnique", "Article", ErrorMessage = "Thème déjà existant")]
    public string Title { get; set; } = null!;

    [Required(ErrorMessage = "Le contenu doit être rempli")]
    public string Content { get; set; } = null!;

    [Required]
    public string AuthorId { get; set; } = null!;
    public string Author { get; set; } = null!;

    public List<Comment> Comments { get; set; } = [];

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
