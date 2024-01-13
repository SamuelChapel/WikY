using WikY.Business.Contracts.Common;
using WikY.Entities.Comments;
using WikY.Repository.Contracts.Repositories;

namespace WikY.Business.Comments.Delete;

public sealed class DeleteCommentCommandHandler(ICommentRepository commentRepository) : ICommandHandler<DeleteCommentCommand, bool>
{
    private readonly ICommentRepository _commentRepository = commentRepository;

    public async Task<bool> Handle(DeleteCommentCommand command)
    {
        var commentId = CommentId.Create(command.Id);

        var comment = await _commentRepository.GetById(commentId);

        if (comment is not null)
        {
            await _commentRepository.Delete(comment);
            return true;
        }

        return false;
    }
}
