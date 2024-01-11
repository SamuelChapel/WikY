using WikY.Business.Contracts.Common;
using WikY.Entities.Articles;
using WikY.Entities.Authors;
using WikY.Repository.Contracts.Repositories;

namespace WikY.Business.Articles.Create;

public class CreateArticleCommandHandler(IArticleRepository articleRepository)
    : ICommandHandler<CreateArticleCommand, Article>
{
    private readonly IArticleRepository _articleRepository = articleRepository;

    public async Task<Article> Handle(CreateArticleCommand command)
    {
        var article = new Article(command.Title, command.Content, AuthorId.Create(command.AuthorId));

        await _articleRepository.Create(article);

        return article;
    }
}
