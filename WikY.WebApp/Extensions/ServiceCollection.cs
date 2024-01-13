using WikY.WebApp.Controllers;
using WikY.WebApp.Mappers;

namespace WikY.WebApp.Extensions;

public static class ServiceCollection
{
    public static IServiceCollection AddWebApp(this IServiceCollection services)
    {
        services.AddTransient<AuthorMapper>();
        services.AddTransient<ArticleMapper>();
        services.AddTransient<CommentMapper>();

        services.AddScoped<AuthorController>();

        return services;
    }
}
