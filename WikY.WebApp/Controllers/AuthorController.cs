using Microsoft.AspNetCore.Mvc;

namespace WikY.WebApp.Controllers;

public class AuthorController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
