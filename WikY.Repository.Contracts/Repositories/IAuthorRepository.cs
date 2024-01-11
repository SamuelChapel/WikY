using WikY.Entities.Authors;
using WikY.Repository.Persistence.Repositories.Base;

namespace WikY.Repository.Contracts.Repositories;

public interface IAuthorRepository : IReadRepository<Author, AuthorId>
{
}
