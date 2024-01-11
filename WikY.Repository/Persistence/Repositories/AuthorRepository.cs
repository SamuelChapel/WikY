using Microsoft.EntityFrameworkCore;
using WikY.Entities.Authors;
using WikY.Repository.Contracts.Repositories;
using WikY.Repository.Persistence.Contexts;

namespace WikY.Repository.Persistence.Repositories;

public class AuthorRepository(WikYDbContext dbContext) : IAuthorRepository
{
    private readonly WikYDbContext _dbContext = dbContext;

    public Task<List<Author>> GetAll()
    {
        return _dbContext.Authors.ToListAsync();
    }

    public Task<Author?> GetById(AuthorId id)
    {
        return _dbContext.Authors.FirstOrDefaultAsync(a => a.Id == id);
    }
}
