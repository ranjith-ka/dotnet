using Microsoft.AspNetCore.Mvc;

namespace dotnet.Data;

public class Controller1 : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}