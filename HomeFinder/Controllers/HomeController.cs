using HomeFinder.Models;
using Microsoft.AspNetCore.Mvc;

namespace HomeFinder.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Home";

            return View();
        }

        public IActionResult Search()
        {
            QueryField query = new() { };

            return View(query);
        }


    }
}
