using WikY.Entities.Articles;
using WikY.Entities.Comments;
using WikY.Repository.Persistence.Repositories.Base;

namespace WikY.Repository.Contracts.Repositories;

public interface ICommentRepository : IReadRepository<Comment, CommentId>, IWriteRepository<Comment, CommentId>
{
    public Task<List<Comment>> GetCommentsByArticleId(ArticleId articleId);
}
