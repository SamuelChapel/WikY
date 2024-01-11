using Bogus;
using WikY.Entities.Authors;
using WikY.Entities.Comments;
using WikY.Entities.Common;

namespace WikY.Entities.Articles;

public sealed class Article : Entity<ArticleId>
{
    public string Title { get; private set; }

    public string Content { get; private set; }

    public AuthorId AuthorId { get; private set; }
    public Author? Author { get; private set; }

    private readonly List<Comment> _comments = [];
    public IReadOnlyList<Comment> Comments => _comments.AsReadOnly();

    public Article(string title, string content, AuthorId authorId)
        : base(ArticleId.CreateUnique())
    {
        Title = title;
        Content = content;
        AuthorId = authorId;
    }

    public static IEnumerable<Article> GetRandomArticles(List<AuthorId> authorIds, int count = 500)
    {
        return Enumerable.Range(0, count).Select(i => new Faker<Article>()
            .RuleFor(a => a.Id, ArticleId.CreateUnique())
            .RuleFor(a => a.Title, f => f.Lorem.Word())
            .RuleFor(a => a.Content, f => f.Lorem.Paragraph())
            .RuleFor(a => a.AuthorId, authorIds[Random.Shared.Next(authorIds.Count)])
            .RuleFor(a => a.CreatedAt, f => f.Date.Past(2))
            .RuleFor(a => a.UpdatedAt, f => f.Date.Past(1))
            .Generate());
    }

#pragma warning disable CS8618
    public Article() : base(ArticleId.CreateUnique())
    {

    }
#pragma warning restore CS8618
}
