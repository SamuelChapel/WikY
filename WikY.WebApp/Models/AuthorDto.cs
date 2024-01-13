using System.ComponentModel.DataAnnotations;

namespace WikY.WebApp.Models;

public sealed class AuthorDto
{
    public string Id { get; set; } = null!;

    [Required]
    [StringLength(30)]
    public string FirstName { get; set; } = null!;

    [Required]
    [StringLength(30)]
    public string LastName { get; set; } = null!;

}
