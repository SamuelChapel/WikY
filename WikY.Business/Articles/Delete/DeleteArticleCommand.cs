using WikY.Business.Contracts.Common;

namespace WikY.Business.Articles.Delete;

public record DeleteArticleCommand(
    string ArticleId
    ) : ICommand;
