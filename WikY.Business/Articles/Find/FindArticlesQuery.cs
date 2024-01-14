using WikY.Business.Contracts.Common;

namespace WikY.Business.Articles.Find;

public record FindArticlesQuery(
    ArticleProperties OrderBy = ArticleProperties.CreationDate,
    OrderByDirection Direction = OrderByDirection.Descending,
    int? Page = null,
    int? Count = null,
    string? SearchString = null
    ) : IQuery;

public enum ArticleProperties
{
    CreationDate,
    UpdatedDate,
    Title,
    Content,
    AuthorName
}

public enum OrderByDirection
{
    Ascending,
    Descending
}