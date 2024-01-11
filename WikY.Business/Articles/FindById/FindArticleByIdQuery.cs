using WikY.Business.Contracts.Common;

namespace WikY.Business.Articles.FindById;

public record FindArticleByIdQuery(
    string ArticleId
    ) : IQuery;
