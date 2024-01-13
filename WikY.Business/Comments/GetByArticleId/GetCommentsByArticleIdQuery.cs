using WikY.Business.Contracts.Common;

namespace WikY.Business.Comments.GetByArticleId;

public record GetCommentsByArticleIdQuery(
    string ArticleId
    ) : IQuery;

