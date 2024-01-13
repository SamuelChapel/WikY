using Microsoft.EntityFrameworkCore;
using WikY.Entities.Articles;
using WikY.Entities.Comments;
using WikY.Repository.Contracts.Repositories;
using WikY.Repository.Persistence.Contexts;

namespace WikY.Repository.Persistence.Repositories;

public class CommentRepository(WikYDbContext dbContext) : ICommentRepository
{
    private readonly WikYDbContext _dbContext = dbContext;

    public async Task<Comment?> GetById(CommentId id)
    {
        return await _dbContext.Comments.FirstOrDefaultAsync(c => c.Id == id);
    }

    public Task<List<Comment>> GetAll()
    {
        return _dbContext.Comments.ToListAsync();
    }

    public async Task<Comment> Create(Comment comment)
    {
        await _dbContext.AddAsync(comment);

        await _dbContext.SaveChangesAsync();

        return comment;
    }

    public async Task<Comment> Update(Comment comment)
    {
        _dbContext.Update(comment);

        await _dbContext.SaveChangesAsync();

        return comment;
    }

    public async Task Delete(Comment comment)
    {
        _dbContext.Comments.Remove(comment);

        await _dbContext.SaveChangesAsync();
    }

    public async Task<List<Comment>> GetCommentsByArticleId(ArticleId articleId)
    {
        return await _dbContext.Comments
            .Include(c => c.Author)
            .Where(c => c.ArticleId == articleId)
            .ToListAsync();
    }
}
