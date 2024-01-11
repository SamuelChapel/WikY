using WikY.WebApp.Mappers;

namespace WikY.WebApp.Extensions;

public static class ServiceCollection
{
    public static IServiceCollection AddWebApp(this IServiceCollection services)
    {
        services.AddTransient<AuthorMapper>();
        services.AddTransient<ArticleMapper>();

        return services;
    }
}
