using WikY.Business.Contracts.Common;

namespace WikY.Business.Articles.Find;

public record FindArticlesQuery(
    ArticleProperties OrderBy = ArticleProperties.CreationDate,
    int? Page = null,
    int? Count = null
    ) : IQuery;

public enum ArticleProperties
{
    CreationDate,
    Title,
    AuthorName
}
