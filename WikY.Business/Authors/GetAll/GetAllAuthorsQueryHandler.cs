using WikY.Business.Contracts.Common;
using WikY.Entities.Authors;
using WikY.Repository.Contracts.Repositories;

namespace WikY.Business.Authors.GetAll;

public class GetAllAuthorsQueryHandler(IAuthorRepository authorRepository) : IQueryHandler<GetAllAuthorsQuery, List<Author>>
{
    private readonly IAuthorRepository _authorRepository = authorRepository;

    public Task<List<Author>> Handle(GetAllAuthorsQuery query)
    {
        return _authorRepository.GetAll();
    }
}
