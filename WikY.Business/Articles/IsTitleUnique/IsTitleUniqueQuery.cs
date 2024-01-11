using WikY.Business.Contracts.Common;

namespace WikY.Business.Articles.IsTitleUnique;

public record IsTitleUniqueQuery(
    string Title
    ) : IQuery;
