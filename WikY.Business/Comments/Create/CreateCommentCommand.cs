using WikY.Business.Contracts.Common;

namespace WikY.Business.Comments.Create;

public record CreateCommentCommand(
    string ArticleId,
    string AuthorId,
    string Content
    ) : ICommand;
