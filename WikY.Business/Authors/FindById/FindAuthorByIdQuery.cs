using WikY.Business.Contracts.Common;

namespace WikY.Business.Authors.FindById;

public record FindAuthorByIdQuery(
    string AuthorId
    ) : IQuery;
