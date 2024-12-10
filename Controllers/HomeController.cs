using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewData["Message"] = "Bienvenue sur notre application !";
        return View();
    }
}