using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class EpisodeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
