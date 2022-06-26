using FPTLibrary.Models;
using FPTLibrary.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace FPTLibrary.Controllers
{
    public class StoreOwnerController : Controller
    {
        private readonly ApplicationDbContext context;
        public StoreOwnerController(ApplicationDbContext _context)
        {
            context = _context;
        }
        public IActionResult Store_owner()
        {
            var store_owner = context.Store_Owners.ToList();
            return View(store_owner);
        }

        public IActionResult Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var store_owner = context.Store_Owners
                .FirstOrDefault(m => m.Id == id);
            return View(store_owner);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var store_owner = context.Store_Owners.Find(id);
            return View(store_owner);
        }
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult Edit(Store_Owner store_owner)
        {
            if (ModelState.IsValid)
            {
                context.Store_Owners.Update(store_owner);
                context.SaveChanges();
                return RedirectToAction("Store_owner");
            }
            return View(store_owner);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var store_owner = context.Store_Owners.Find(id);
            context.Store_Owners.Remove(store_owner);
            return RedirectToAction("Store_Owner");
        }
        [HttpGet]
        public async Task<IActionResult> Index(string Search)
        {
            ViewData["GetStore_Owner"] = Search;
            var query = from item in context.Store_Owners select item;
            if (!string.IsNullOrEmpty(Search))
            {
                query = query.Where(c => c.Name.Contains(Search));
            }
            return View(await query.AsNoTracking().ToListAsync());
        }
    }
}
