using WikY.Business.Contracts.Common;
using WikY.Entities.Articles;
using WikY.Repository.Contracts.Repositories;

namespace WikY.Business.Articles.Find;

public class FindArticlesQueryHandler(IArticleRepository articleRepository) : IQueryHandler<FindArticlesQuery, List<Article>>
{
    private const int DEFAULTPAGE = 1;
    private const int DEFAULTCOUNT = 50;

    private readonly IArticleRepository _articleRepository = articleRepository;

    public async Task<List<Article>> Handle(FindArticlesQuery query)
    {
        var articles = await _articleRepository.GetAll();

        var page = ParsePage(query.Page);
        var count = ParseMaxResult(query.Count);
        var startIndex = (page - 1) * count;

        return articles
            .OrderByDescending(x => x.CreatedAt)
            .Skip(startIndex)
            .Take(count)
            .ToList();
    }

    private int ParsePage(int? pageQuery)
        => ParseIntegerOrDefaultValue(pageQuery, DEFAULTPAGE);

    private int ParseMaxResult(int? maxResultQuery)
        => ParseIntegerOrDefaultValue(maxResultQuery, DEFAULTCOUNT);

    private int ParseIntegerOrDefaultValue(int? integerToParse, int defaultValue)
        => integerToParse ?? defaultValue;
}
