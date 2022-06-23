using Microsoft.AspNetCore.Mvc;

namespace FPTLibrary.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
