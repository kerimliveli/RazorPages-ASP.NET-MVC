using Microsoft.AspNetCore.Mvc;
using ViewComponentLesson.Context;

namespace ViewComponentLesson.Controllers;

public class HomeController(AppDbContext context) : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult GetCategories()
    {
        return Json(context.Categories);
    }
}