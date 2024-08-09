using MediumIOC.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MediumIOC.Web.Controllers
{
    public class HomeController : Controller
    {
        //constructor injection
        private readonly ITransientDateService _transientDateService;
        public HomeController(ITransientDateService transientDateService)
        {
            _transientDateService = transientDateService;
        }

        //method injection
        public IActionResult Index([FromServices] ITransientDateService _transientDateServiceMethod)
        {
            ViewBag.ControllerTime = _transientDateService.GetDateTime.TimeOfDay.ToString();
            ViewBag.MethodTime = _transientDateServiceMethod.GetDateTime.TimeOfDay.ToString();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
