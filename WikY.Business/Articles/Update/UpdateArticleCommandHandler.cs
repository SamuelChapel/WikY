using WikY.Business.Contracts.Common;
using WikY.Entities.Articles;
using WikY.Repository.Contracts.Repositories;

namespace WikY.Business.Articles.Update;

public sealed class UpdateArticleCommandHandler(IArticleRepository articleRepository) : ICommandHandler<UpdateArticleCommand, Article?>
{
    private readonly IArticleRepository _articleRepository = articleRepository;

    public async Task<Article?> Handle(UpdateArticleCommand command)
    {
        var articleId = ArticleId.Create(command.ArticleId);

        var article = await _articleRepository.GetById(articleId);

        if (article is not null)
        {
            if (command.Title is not null)
                article.SetTitle(command.Title);

            if (command.Content is not null)
                article.SetContent(command.Content);

            await _articleRepository.Update(article);
        }

        return article;
    }
}
