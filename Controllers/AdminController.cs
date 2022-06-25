using FPTLibrary.Models;
using FPTLibrary.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace FPTLibrary.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext context;
        public AdminController(ApplicationDbContext _context)
        {
            context = _context;
        }
        public IActionResult Index()
        {
            var admin = context.Admin.ToList();
            return View(admin);
        }
    }
}
