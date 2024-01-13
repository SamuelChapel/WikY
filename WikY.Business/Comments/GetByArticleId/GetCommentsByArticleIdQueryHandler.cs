using WikY.Business.Contracts.Common;
using WikY.Entities.Articles;
using WikY.Entities.Comments;
using WikY.Repository.Contracts.Repositories;

namespace WikY.Business.Comments.GetByArticleId;

public sealed class GetCommentsByArticleIdQueryHandler(ICommentRepository commentRepository) : IQueryHandler<GetCommentsByArticleIdQuery, List<Comment>>
{
    private readonly ICommentRepository _commentRepository = commentRepository;

    public Task<List<Comment>> Handle(GetCommentsByArticleIdQuery query)
    {
        return _commentRepository.GetCommentsByArticleId(ArticleId.Create(query.ArticleId));
    }
}
