using Microsoft.AspNetCore.Mvc;

namespace FPTLibrary.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
