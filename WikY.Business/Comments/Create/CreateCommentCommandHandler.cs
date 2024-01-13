using WikY.Business.Authors.FindById;
using WikY.Business.Contracts.Common;
using WikY.Entities.Articles;
using WikY.Entities.Authors;
using WikY.Entities.Comments;
using WikY.Repository.Contracts.Repositories;

namespace WikY.Business.Comments.Create;

public class CreateCommentCommandHandler(
    ICommentRepository commentRepository,
    IQueryHandler<FindAuthorByIdQuery, Author?> findAuthorHandler
    ) : ICommandHandler<CreateCommentCommand, Comment?>
{
    private readonly ICommentRepository _commentRepository = commentRepository;
    private readonly IQueryHandler<FindAuthorByIdQuery, Author?> _findAuthorHandler = findAuthorHandler;

    public async Task<Comment?> Handle(CreateCommentCommand command)
    {
        var author = await _findAuthorHandler.Handle(new FindAuthorByIdQuery(command.AuthorId));

        if (author is not null)
        {
            var comment = new Comment(author.Id, ArticleId.Create(command.ArticleId), command.Content);

            await _commentRepository.Create(comment);

            return comment;
        }

        return null;
    }
}
