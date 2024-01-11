using Microsoft.EntityFrameworkCore;
using WikY.Entities.Articles;
using WikY.Repository.Contracts.Repositories;
using WikY.Repository.Persistence.Contexts;

namespace WikY.Repository.Persistence.Repositories;

public sealed class ArticleRepository(WikYDbContext dbContext) : IArticleRepository
{
    private readonly WikYDbContext _dbContext = dbContext;

    public async Task<Article?> GetById(ArticleId id)
    {
        var articles = await _dbContext.Articles
            .Include(a => a.Author)
            .Where(a => a.Id == id).ToListAsync();
        var article = articles
            .FirstOrDefault();

        return article;
    }

    public async Task<List<Article>> GetAll()
    {
        return await _dbContext.Articles
            .Include(a => a.Author)
            .ToListAsync();
    }

    public async Task<Article> Create(Article article)
    {
        _dbContext.Add(article);

        await _dbContext.SaveChangesAsync();

        return article;
    }

    public async Task<Article> Update(Article article)
    {
        _dbContext.Update(article);

        await _dbContext.SaveChangesAsync();

        return article;
    }

    public async Task<bool> Delete(ArticleId id)
    {
        Article? article = await GetById(id);

        if (article is null)
            return false;

        _dbContext.Articles.Remove(article);

        await _dbContext.SaveChangesAsync();

        return true;
    }

    public async Task<bool> IsTitleUnique(string title)
    {
        return await _dbContext.Articles.AnyAsync(a => a.Title == title);
    }
}
