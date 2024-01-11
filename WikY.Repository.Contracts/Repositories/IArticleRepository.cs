using WikY.Entities.Articles;
using WikY.Repository.Persistence.Repositories.Base;

namespace WikY.Repository.Contracts.Repositories;

public interface IArticleRepository : IReadRepository<Article, ArticleId>, IWriteRepository<Article, ArticleId>
{
    Task<bool> IsTitleUnique(string title);
}
