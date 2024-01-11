using WikY.Business.Contracts.Common;

namespace WikY.Business.Articles.Create;

public record CreateArticleCommand(
    string Title,
    string Content,
    string AuthorId
    ) : ICommand;
