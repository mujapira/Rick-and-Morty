using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class LocationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
