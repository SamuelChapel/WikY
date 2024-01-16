using WikY.Business.Contracts.Common;
using WikY.Entities.Articles;
using WikY.Repository.Contracts.Repositories;

namespace WikY.Business.Articles.Find;

public class FindArticlesQueryHandler(IArticleRepository articleRepository) : IQuerySearcherHandler<FindArticlesQuery, List<Article>, int>
{
    private const int DEFAULTPAGE = 1;
    private const int DEFAULTCOUNT = 50;

    private readonly IArticleRepository _articleRepository = articleRepository;

    public async Task<int> Count(FindArticlesQuery query)
    {
        return await _articleRepository.Count();
    }

    public async Task<List<Article>> Search(FindArticlesQuery query)
    {
        IEnumerable<Article> articles = await _articleRepository.GetAll();

        if (query.SearchString is not null)
            articles = FilterArticles(articles, query.SearchString);

        var page = query.Page ?? DEFAULTPAGE;
        var count = query.Count ?? DEFAULTCOUNT;
        var startIndex = (page - 1) * count;

        articles = articles
            .Skip(startIndex)
            .Take(count);

        articles = OrderArticles(articles, query.Direction, query.OrderBy);

        return articles.ToList();
    }

    private IEnumerable<Article> FilterArticles(IEnumerable<Article> articles, string searchString)
    {
        return articles.Where(a =>
            a.Author!.FullName.Contains(searchString, StringComparison.CurrentCultureIgnoreCase) ||
            a.Title.Contains(searchString, StringComparison.CurrentCultureIgnoreCase) ||
            a.Content.Contains(searchString));
    }

    private IEnumerable<Article> OrderArticles(IEnumerable<Article> articles, OrderByDirection direction, ArticleProperties properties)
    {
        return direction switch
        {
            OrderByDirection.Ascending => properties switch
            {
                ArticleProperties.CreationDate => articles.OrderBy(a => a.CreatedAt),
                ArticleProperties.Title => articles.OrderBy(a => a.Title),
                ArticleProperties.AuthorName => articles.OrderBy(a => a.Author!.FullName),
                ArticleProperties.UpdatedDate => articles.OrderBy(a => a.UpdatedAt),
                ArticleProperties.Content => articles.OrderBy(a => a.Content),
                _ => articles.OrderBy(a => a.CreatedAt),
            },

            OrderByDirection.Descending => properties switch
            {
                ArticleProperties.CreationDate => articles.OrderByDescending(a => a.CreatedAt),
                ArticleProperties.Title => articles.OrderByDescending(a => a.Title),
                ArticleProperties.AuthorName => articles.OrderByDescending(a => a.Author!.FullName),
                ArticleProperties.UpdatedDate => articles.OrderByDescending(a => a.UpdatedAt),
                ArticleProperties.Content => articles.OrderByDescending(a => a.Content),
                _ => articles.OrderByDescending(a => a.CreatedAt),
            },

            _ => articles.OrderByDescending(a => a.CreatedAt),
        };
    }
}
