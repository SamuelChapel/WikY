using WikY.Entities.Common;

namespace WikY.Entities.Comments;

public sealed class CommentId(Guid value) : EntityId<Guid>(value)
{
    public static CommentId CreateUnique()
    {
        return new CommentId(Guid.NewGuid());
    }
}