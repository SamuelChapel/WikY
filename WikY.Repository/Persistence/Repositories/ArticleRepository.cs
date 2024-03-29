﻿using Microsoft.EntityFrameworkCore;
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
            .Include(a => a.Comments)
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
        await _dbContext.AddAsync(article);

        await _dbContext.SaveChangesAsync();

        return article;
    }

    public async Task<Article> Update(Article article)
    {
        _dbContext.Update(article);

        await _dbContext.SaveChangesAsync();

        return article;
    }

    public async Task Delete(Article article)
    {
        _dbContext.Articles.Remove(article);

        await _dbContext.SaveChangesAsync();
    }

    public async Task<bool> IsTitleUnique(string title)
    {
        return await _dbContext.Articles.AnyAsync(a => a.Title == title);
    }

    public async Task<int> Count()
    {
        return await _dbContext.Articles.CountAsync();
    }
}
