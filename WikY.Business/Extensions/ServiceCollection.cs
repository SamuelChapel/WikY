using Microsoft.Extensions.DependencyInjection;
using WikY.Business.Articles.Create;
using WikY.Business.Articles.Delete;
using WikY.Business.Articles.Find;
using WikY.Business.Articles.FindById;
using WikY.Business.Articles.IsTitleUnique;
using WikY.Business.Articles.Update;
using WikY.Business.Authors.FindById;
using WikY.Business.Authors.GetAll;
using WikY.Business.Comments.Create;
using WikY.Business.Comments.Delete;
using WikY.Business.Comments.GetByArticleId;
using WikY.Business.Contracts.Common;
using WikY.Entities.Articles;
using WikY.Entities.Authors;
using WikY.Entities.Comments;

namespace WikY.Business.Extensions;

public static class ServiceCollection
{
    public static IServiceCollection AddBusiness(this IServiceCollection services)
    {
        services.AddTransient<IQueryHandler<GetAllAuthorsQuery, List<Author>>, GetAllAuthorsQueryHandler>();
        services.AddTransient<IQueryHandler<FindAuthorByIdQuery, Author?>, FindAuthorByIdQueryHandler>();

        services.AddTransient<ICommandHandler<CreateArticleCommand, Article>, CreateArticleCommandHandler>();
        services.AddTransient<IQueryHandler<FindArticlesQuery, List<Article>>, FindArticlesQueryHandler>();
        services.AddTransient<IQueryHandler<FindArticleByIdQuery, Article?>, FindArticleByIdQueryHandler>();
        services.AddTransient<ICommandHandler<DeleteArticleCommand, bool>, DeleteArticleCommandHandler>();
        services.AddTransient<ICommandHandler<UpdateArticleCommand, Article?>, UpdateArticleCommandHandler>();
        services.AddTransient<ICommandHandler<CreateCommentCommand, Comment?>, CreateCommentCommandHandler>();

        services.AddTransient<IQueryHandler<IsTitleUniqueQuery, bool>, IsTitleUniqueQueryHandler>();

        services.AddTransient<IQueryHandler<GetCommentsByArticleIdQuery, List<Comment>>, GetCommentsByArticleIdQueryHandler>();
        services.AddTransient<ICommandHandler<DeleteCommentCommand, bool>, DeleteCommentCommandHandler>();

        return services;
    }
}
