using WikY.Business.Contracts.Common;
using WikY.Repository.Contracts.Repositories;

namespace WikY.Business.Articles.IsTitleUnique;

public class IsTitleUniqueQueryHandler(IArticleRepository articleRepository) : IQueryHandler<IsTitleUniqueQuery, bool>
{
    private readonly IArticleRepository _articleRepository = articleRepository;

    public Task<bool> Handle(IsTitleUniqueQuery query)
    {
        return _articleRepository.IsTitleUnique(query.Title);
    }
}
