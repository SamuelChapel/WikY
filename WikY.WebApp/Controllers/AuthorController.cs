using Microsoft.AspNetCore.Mvc;
using WikY.Business.Articles.Find;
using WikY.Business.Contracts.Common;
using WikY.Entities.Authors;
using WikY.WebApp.Mappers;

namespace WikY.WebApp.Controllers;

public class AuthorController(
    ILogger<AuthorController> logger,
    AuthorMapper mapper) : Controller
{
    private readonly ILogger<AuthorController> _logger = logger;
    private readonly AuthorMapper _mapper = mapper;

    public IActionResult Index()
    {
        return View();
    }

    public async Task<ActionResult> GetAllAuthors(
        [FromServices] IQueryHandler<FindArticlesQuery, List<Author>> handler
        )
    {
        var query = new FindArticlesQuery();
        var authors = await handler.Handle(query);

        var authorModels = authors.Select(_mapper.Map).ToList();

        return Json(authorModels);
    }
}
