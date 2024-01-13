using WikY.Business.Contracts.Common;

namespace WikY.Business.Comments.Delete;

public record DeleteCommentCommand(
    string Id
    ) : ICommand;
