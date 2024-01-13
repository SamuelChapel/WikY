using WikY.Business.Contracts.Common;

namespace WikY.Business.Articles.Update;

public record UpdateArticleCommand(
    string ArticleId,
    string? Title,
    string? Content
    ) : ICommand;
