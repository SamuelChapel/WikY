using WikY.Entities.Authors;
using WikY.Entities.Comments;
using WikY.Entities.Common;

namespace WikY.Entities.Articles;

public sealed class Article : Entity<ArticleId>
{
    public string Theme { get; private set; }

    public string Content { get; private set; }

    public AuthorId AuthorId { get; private set; }
    public Author? Author { get; private set; }

    private readonly List<Comment> _comments = [];
    public IReadOnlyList<Comment> Comments => _comments.AsReadOnly();

    public Article(string theme, AuthorId authorId, string content)
        : base(ArticleId.CreateUnique())
    {
        Theme = theme;
        AuthorId = authorId;
        Content = content;
    }

    public void AddComment(Comment comment)
    {
    }
}
