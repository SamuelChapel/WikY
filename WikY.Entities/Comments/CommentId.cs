using WikY.Entities.Common;

namespace WikY.Entities.Comments;

public sealed class CommentId(Guid value) : EntityId<Guid>(value)
{
    public static CommentId Create(string value)
    {
        var guid = Guid.Parse(value);

        return new CommentId(guid);
    }
    public static CommentId CreateUnique()
    {
        return new CommentId(Guid.NewGuid());
    }
}