using Riok.Mapperly.Abstractions;
using WikY.Entities.Comments;
using WikY.WebApp.Models;

namespace WikY.WebApp.Mappers;

[Mapper(RequiredMappingStrategy = RequiredMappingStrategy.Target)]
public partial class CommentMapper
{
    [MapProperty($"{nameof(Comment.Author)}.{nameof(Comment.Author.FullName)}", nameof(CommentDto.Author))]
    public partial CommentDto Map(Comment comment);
}
