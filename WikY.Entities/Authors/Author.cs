using WikY.Entities.Articles;
using WikY.Entities.Common;

namespace WikY.Entities.Authors;

public sealed class Author : Entity<AuthorId>
{
    public readonly List<Article> _articles = [];
    public IReadOnlyList<Article> Articles => _articles.AsReadOnly();

    public string FirstName { get; private set; }
    public string LastName { get; private set; }

    public Author(string firstName, string lastName)
        : base(AuthorId.CreateUnique())
    {
        FirstName = firstName;
        LastName = lastName;
    }
}
