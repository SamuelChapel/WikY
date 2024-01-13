using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WikY.Repository.Contracts.Repositories;
using WikY.Repository.Persistence.Contexts;
using WikY.Repository.Persistence.Repositories;

namespace WikY.Repository.Extensions;

public static class ServiceCollection
{
    public static IServiceCollection AddRepository(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<WikYDbContext>(o =>
        {
            //o.UseSqlServer(configuration.GetConnectionString("WikY"));

            o.UseSqlServer("Data Source=MSI; Initial Catalog=WikY; Integrated Security=SSPI; TrustServerCertificate=True");
        });

        services.AddTransient<IArticleRepository, ArticleRepository>();
        services.AddTransient<IAuthorRepository, AuthorRepository>();
        services.AddTransient<ICommentRepository, CommentRepository>();

        return services;
    }
}
