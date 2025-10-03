using Microsoft.AspNetCore.Mvc;

namespace Bike_Zone.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
