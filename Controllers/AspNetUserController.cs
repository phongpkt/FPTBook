﻿using FPTLibrary.Models;
using FPTLibrary.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace FPTLibrary.Controllers
{
    public class AspNetUserController : Controller
    {
        private readonly ApplicationDbContext context;
        public AspNetUserController(ApplicationDbContext _context)
        {
            context = _context;
        }
        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            var user = context.Users.ToList();
            return View(user);
        }
        [Authorize(Roles = "Admin")]
        public IActionResult CatRequest()
        {
            var category = context.Categories.ToList();
            return View(category);
        }
        [Authorize(Roles = "Admin")]
        public IActionResult Person(string? id)
        {
            var user = context.Users
                .FirstOrDefault(u => u.Id == id);
            return View(user);
        }
        [HttpGet]
        public async Task<IActionResult> Index(string userSearch)
        {
            ViewData["GetUser"] = userSearch;
            var query = from item in context.Users select item;
            if (!string.IsNullOrEmpty(userSearch))
            {
                query = query.Where(b => b.Name.Contains(userSearch));
            }
            return View(await query.AsNoTracking().ToListAsync());
        }
    }
}
