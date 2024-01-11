using WikY.Entities.Authors;
using WikY.Entities.Comments;
using WikY.Entities.Common;

namespace WikY.Entities.Articles;

public sealed class Article : Entity<ArticleId>
{
    private readonly List<Comment> _comments = [];
    public IReadOnlyList<Comment> Comments => _comments.AsReadOnly();

    public string Theme { get; private set; }

    public AuthorId AuthorId { get; private set; }
    public Author Author { get; private set; }

    public string Content { get; private set; }

    public Article(string theme, string author, string content)
        : base(ArticleId.CreateUnique())
    {
        Theme = theme;
        Author = author;
        Content = content;
    }

    public void AddComment(Comment comment)
    {
        if (comment.)
    }
}
