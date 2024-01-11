using WikY.Entities.Common;

namespace WikY.Entities.Articles;

public sealed class ArticleId(Guid value) : EntityId<Guid>(value)
{
    public static ArticleId CreateUnique()
    {
        return new ArticleId(Guid.NewGuid());
    }
}