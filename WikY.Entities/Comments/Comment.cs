using WikY.Entities.Articles;
using WikY.Entities.Authors;
using WikY.Entities.Common;

namespace WikY.Entities.Comments;

public sealed class Comment : Entity<CommentId>
{
    public AuthorId AuthorId { get; private set; }
    public Author? Author { get; private set; }

    public ArticleId ArticleId { get; private set; }
    public Article? Article { get; private set; }

    public string Content { get; private set; }

    public Comment(AuthorId authorId, ArticleId articleId, string content) : base(CommentId.CreateUnique())
    {
        AuthorId = authorId;
        ArticleId = articleId;
        Content = content;
    }
}
