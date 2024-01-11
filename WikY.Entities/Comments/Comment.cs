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
}
