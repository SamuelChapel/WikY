using Bogus;
using WikY.Entities.Articles;
using WikY.Entities.Common;

namespace WikY.Entities.Comments;

public sealed class Comment : Entity<CommentId>
{
    public ArticleId ArticleId { get; private set; }
    public Article? Article { get; private set; }

    public string Content { get; private set; }

    public Comment(ArticleId articleId, string content) : base(CommentId.CreateUnique())
    {
        ArticleId = articleId;
        Content = content;
    }

    public static IEnumerable<Comment> GetRandomComments(List<ArticleId> articleIds, int count = 2000)
    {
        return Enumerable.Range(0, count).Select(i => new Faker<Comment>()
            .RuleFor(a => a.Id, CommentId.CreateUnique())
            .RuleFor(a => a.Content, f => f.Lorem.Word())
            .RuleFor(a => a.ArticleId, articleIds[Random.Shared.Next(articleIds.Count)])
            .RuleFor(a => a.CreatedAt, f => f.Date.Past(2))
            .RuleFor(a => a.UpdatedAt, f => f.Date.Past(1))
            .Generate());
    }

#pragma warning disable CS8618
    public Comment() : base(CommentId.CreateUnique())
    {

    }
#pragma warning restore CS8618
}
