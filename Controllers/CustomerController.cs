using FPTLibrary.Models;
using FPTLibrary.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace FPTLibrary.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext context;
        public CustomerController(ApplicationDbContext _context)
        {
            context = _context;
        }
        public IActionResult Customer()
        {
            var customer = context.Customers.ToList();
            return View(customer);
        }
        public IActionResult Info(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var customer = context.Customers
                .FirstOrDefault(m => m.Id == id);
            return View(customer);
        }

        [Authorize(Roles = "Admin, Store Owner")]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var customer = context.Customers.Find(id);
            //var order = context.Orders.ToList();    
            //ViewBag.Order = order;
            return View(customer);
        }
        [HttpPost]
        [Authorize(Roles = "Admin, Store Owner")]
        public IActionResult Edit(Customer customer)
        {
            if (ModelState.IsValid)
            {
                context.Customers.Update(customer);
                context.SaveChanges();
                return RedirectToAction("Customer");
            }
            return View(customer);
        }


        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var customer = context.Customers.Find(id);
            context.Customers.Remove(customer);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Index(string CustomerSearch)
        {
            ViewData["GetCustomer"] = CustomerSearch;
            var query = from item in context.Customers select item;
            if (!string.IsNullOrEmpty(CustomerSearch))
            {
                query = query.Where(c => c.FirstName.Contains(CustomerSearch) || c.LastName.Contains(CustomerSearch));
            }
            return View(await query.AsNoTracking().ToListAsync());
        }
    }
}
