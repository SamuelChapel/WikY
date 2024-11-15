using Bogus;
using Bogus.Extensions;
using WikY.Entities.Articles;
using WikY.Entities.Authors;
using WikY.Entities.Common;

namespace WikY.Entities.Comments;

public sealed class Comment : Entity<CommentId>
{
    public ArticleId ArticleId { get; private set; }
    public Article? Article { get; private set; }

    public AuthorId AuthorId { get; private set; }
    public Author? Author { get; private set; }

    public string Content { get; private set; }

    public Comment(AuthorId authorId, ArticleId articleId, string content) : base(CommentId.CreateUnique())
    {
        AuthorId = authorId;
        ArticleId = articleId;
        Content = content;
    }

    public static IEnumerable<Comment> GetRandomComments(List<Article> articles, List<AuthorId> authorIds, int count = 2000)
    {
        var articlesIds = articles.Select(a => a.Id).ToList();

        return Enumerable.Range(0, count).Select(i => new Faker<Comment>()
            .RuleFor(a => a.Id, CommentId.CreateUnique())
            .RuleFor(a => a.ArticleId, articlesIds[Random.Shared.Next(articlesIds.Count)])
            .RuleFor(a => a.Content, (f, current) => f.Rant.Review(articles.Find(a => a.Id == current.ArticleId)!.Title).ClampLength(max: 100))
            .RuleFor(a => a.AuthorId, authorIds[Random.Shared.Next(authorIds.Count)])
            .RuleFor(a => a.CreatedAt, f => f.Date.Past(2).ToUniversalTime())
            .RuleFor(a => a.UpdatedAt, f => f.Date.Past(1).ToUniversalTime())
            .Generate());
    }

#pragma warning disable CS8618
    public Comment() : base(CommentId.CreateUnique())
    {

    }
#pragma warning restore CS8618
}
