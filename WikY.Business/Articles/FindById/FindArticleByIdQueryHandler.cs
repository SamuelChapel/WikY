using WikY.Business.Contracts.Common;
using WikY.Entities.Articles;
using WikY.Repository.Contracts.Repositories;

namespace WikY.Business.Articles.FindById;

public class FindArticleByIdQueryHandler(IArticleRepository articleRepository) : IQueryHandler<FindArticleByIdQuery, Article?>
{
    private readonly IArticleRepository _articleRepository = articleRepository;

    public async Task<Article?> Handle(FindArticleByIdQuery query)
    {
        var articleId = ArticleId.Create(query.ArticleId);

        return await _articleRepository.GetById(articleId);
    }
}
