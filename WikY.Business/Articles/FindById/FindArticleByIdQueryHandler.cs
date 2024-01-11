using WikY.Business.Contracts.Common;
using WikY.Entities.Articles;
using WikY.Repository.Contracts.Repositories;

namespace WikY.Business.Articles.FindById;

public class FindArticleByIdQueryHandler(IArticleRepository articleRepository) : IQueryHandler<FindArticleByIdQuery, Article?>
{
    private readonly IArticleRepository _articleRepository = articleRepository;

    public Task<Article?> Handle(FindArticleByIdQuery query)
    {
        var articleId = ArticleId.Create(query.ArticleId);

        return _articleRepository.GetById(articleId);
    }
}
