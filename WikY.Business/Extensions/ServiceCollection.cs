using Microsoft.Extensions.DependencyInjection;
using WikY.Business.Articles.Create;
using WikY.Business.Articles.Find;
using WikY.Business.Articles.FindById;
using WikY.Business.Articles.IsTitleUnique;
using WikY.Business.Authors.GetAll;
using WikY.Business.Contracts.Common;
using WikY.Entities.Articles;
using WikY.Entities.Authors;

namespace WikY.Business.Extensions;

public static class ServiceCollection
{
    public static IServiceCollection AddBusiness(this IServiceCollection services)
    {
        services.AddTransient<IQueryHandler<GetAllAuthorsQuery, List<Author>>, GetAllAuthorsQueryHandler>();

        services.AddTransient<ICommandHandler<CreateArticleCommand, Article>, CreateArticleCommandHandler>();
        services.AddTransient<IQueryHandler<FindArticlesQuery, List<Article>>, FindArticlesQueryHandler>();
        services.AddTransient<IQueryHandler<FindArticleByIdQuery, Article?>, FindArticleByIdQueryHandler>();

        services.AddTransient<IQueryHandler<IsTitleUniqueQuery, bool>, IsTitleUniqueQueryHandler>();

        return services;
    }
}
