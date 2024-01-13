using Riok.Mapperly.Abstractions;
using WikY.Entities.Authors;
using WikY.WebApp.Models;

namespace WikY.WebApp.Mappers;

[Mapper(RequiredMappingStrategy = RequiredMappingStrategy.Target)]
public partial class AuthorMapper
{
    public partial AuthorDto Map(Author author);
}
