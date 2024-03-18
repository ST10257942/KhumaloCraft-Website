using Microsoft.AspNetCore.Mvc;

namespace KhumaloCraft.Controllers  // Adjust namespace to match your project
{
    public class MyWorkController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}