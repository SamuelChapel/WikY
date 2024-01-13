using WikY.Business.Contracts.Common;
using WikY.Entities.Articles;
using WikY.Repository.Contracts.Repositories;

namespace WikY.Business.Articles.Delete;

public sealed class DeleteArticleCommandHandler(IArticleRepository articleRepository) : ICommandHandler<DeleteArticleCommand, bool>
{
    private readonly IArticleRepository _articleRepository = articleRepository;

    public async Task<bool> Handle(DeleteArticleCommand command)
    {
        var articleId = ArticleId.Create(command.ArticleId);

        var article = await _articleRepository.GetById(articleId);

        if (article is not null)
        {
            await _articleRepository.Delete(article);
            return true;
        }

        return false;
    }
}
