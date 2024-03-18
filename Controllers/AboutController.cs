using Microsoft.AspNetCore.Mvc;

namespace KhumaloCraft.Controllers // Adjust namespace to match your project
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
