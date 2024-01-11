using Riok.Mapperly.Abstractions;
using WikY.Entities.Articles;
using WikY.WebApp.Models;

namespace WikY.WebApp.Mappers;

[Mapper(RequiredMappingStrategy = RequiredMappingStrategy.Target)]
public partial class ArticleMapper
{
    [MapProperty($"{nameof(Article.Author)}.{nameof(Article.Author.FullName)}", nameof(ArticleModel.Author))]
    public partial ArticleModel Map(Article article);
}
