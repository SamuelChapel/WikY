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
        List<Article> articles = [];

        Enumerable.Range(0, count).ToList().ForEach(_ =>
        {
            var article = new Faker<Article>()
            .RuleFor(a => a.Id, ArticleId.CreateUnique())
            .RuleFor(a => a.Title, f =>
            {
                string title;
                do
                {
                    title = f.Random.Words(3);
                } while (articles.Any(a => a.Title == title));

                return title;
            })
            .RuleFor(a => a.Content, f => f.Lorem.Paragraph())
            .RuleFor(a => a.AuthorId, authorIds[Random.Shared.Next(authorIds.Count)])
            .RuleFor(a => a.CreatedAt, f => f.Date.Past(2).ToUniversalTime())
            .RuleFor(a => a.UpdatedAt, (f, current) => f.Date.Between(current.CreatedAt, DateTime.UtcNow).ToUniversalTime())
            .Generate();

            articles.Add(article);
        });

        return articles;
    }

    public void SetTitle(string title)
    {
        Title = title;
    }

    public void SetContent(string content)
    {
        Content = content;
    }

    public Article() : base(ArticleId.CreateUnique())
    {
    }
}
