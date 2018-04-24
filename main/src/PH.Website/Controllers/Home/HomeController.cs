using Microsoft.AspNetCore.Mvc;

namespace PH.Website.Controllers.Home
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/Pages/Home.cshtml");
        }
    }
}