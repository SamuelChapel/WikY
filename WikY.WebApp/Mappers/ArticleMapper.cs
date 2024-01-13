using Riok.Mapperly.Abstractions;
using WikY.Entities.Articles;
using WikY.WebApp.Models;

namespace WikY.WebApp.Mappers;

[Mapper(RequiredMappingStrategy = RequiredMappingStrategy.Target)]
public partial class ArticleMapper
{
    [MapProperty($"{nameof(Article.Author)}.{nameof(Article.Author.FullName)}", nameof(ArticleDto.Author))]
    public partial ArticleDto Map(Article article);
}
