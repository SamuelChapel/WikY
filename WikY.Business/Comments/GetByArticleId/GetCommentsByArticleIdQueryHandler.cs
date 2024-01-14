using WikY.Business.Contracts.Common;
using WikY.Entities.Articles;
using WikY.Entities.Comments;
using WikY.Repository.Contracts.Repositories;

namespace WikY.Business.Comments.GetByArticleId;

public sealed class GetCommentsByArticleIdQueryHandler(ICommentRepository commentRepository) : IQueryHandler<GetCommentsByArticleIdQuery, List<Comment>>
{
    private readonly ICommentRepository _commentRepository = commentRepository;

    public async Task<List<Comment>> Handle(GetCommentsByArticleIdQuery query)
    {
        return await _commentRepository.GetCommentsByArticleId(ArticleId.Create(query.ArticleId));
    }
}
