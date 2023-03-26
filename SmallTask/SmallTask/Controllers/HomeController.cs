using Microsoft.AspNetCore.Mvc;
using SmallTask.Models;

namespace SmallTask.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var model = new GreetingModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(GreetingModel greetingModel)
        {
            return View(greetingModel);
        }
    }
}