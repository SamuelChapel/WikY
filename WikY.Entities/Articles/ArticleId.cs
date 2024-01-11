using WikY.Entities.Common;

namespace WikY.Entities.Articles;

public sealed class ArticleId(Guid value) : EntityId<Guid>(value)
{
    public static ArticleId Create(string value)
    {
        var guid = Guid.Parse(value);

        return new ArticleId(guid);
    }

    public static ArticleId CreateUnique()
    {
        return new ArticleId(Guid.NewGuid());
    }
}