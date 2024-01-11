using WikY.Entities.Common;

namespace WikY.Entities.Authors;

public sealed class AuthorId(Guid value) : EntityId<Guid>(value)
{
    public static AuthorId CreateUnique()
    {
        return new AuthorId(Guid.NewGuid());
    }
}