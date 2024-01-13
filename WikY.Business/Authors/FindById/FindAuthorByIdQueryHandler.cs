using WikY.Business.Contracts.Common;
using WikY.Entities.Authors;
using WikY.Repository.Contracts.Repositories;

namespace WikY.Business.Authors.FindById;

public class FindAuthorByIdQueryHandler(IAuthorRepository authorRepository) : IQueryHandler<FindAuthorByIdQuery, Author?>
{
    private readonly IAuthorRepository _authorRepository = authorRepository;

    public async Task<Author?> Handle(FindAuthorByIdQuery command)
    {
        var authorId = AuthorId.Create(command.AuthorId);

        return await _authorRepository.GetById(authorId);
    }
}
