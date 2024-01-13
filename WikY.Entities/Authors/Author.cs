using Bogus;
using WikY.Entities.Articles;
using WikY.Entities.Comments;
using WikY.Entities.Common;

namespace WikY.Entities.Authors;

public sealed class Author : Entity<AuthorId>
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }

    public readonly List<Article> _articles = [];
    public IReadOnlyList<Article> Articles => _articles.AsReadOnly();

    public readonly List<Comment> _comments = [];
    public IReadOnlyList<Comment> Comments => _comments.AsReadOnly();

    public Author(string firstName, string lastName)
        : base(AuthorId.CreateUnique())
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public string FullName => $"{FirstName} {LastName}";

    public static IEnumerable<Author> GetRandomAuthors(int count = 100)
    {
        return Enumerable.Range(0, count).Select(i => new Faker<Author>()
            .RuleFor(a => a.Id, AuthorId.CreateUnique())
            .RuleFor(a => a.FirstName, f => f.Person.FirstName)
            .RuleFor(a => a.LastName, f => f.Person.LastName)
            .RuleFor(a => a.CreatedAt, f => f.Date.Past(2))
            .RuleFor(a => a.UpdatedAt, f => f.Date.Past(1))
            .Generate());
    }

#pragma warning disable CS8618
    public Author() : base(AuthorId.CreateUnique())
    {

    }
#pragma warning restore CS8618
}
