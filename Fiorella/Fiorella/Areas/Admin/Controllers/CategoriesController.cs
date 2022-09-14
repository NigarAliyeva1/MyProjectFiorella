using Fiorella.DAL;
using Fiorella.Helpers;
using Fiorella.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Operations;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using static Fiorella.Helpers.Helper;

namespace Fiorella.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class CategoriesController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IWebHostEnvironment _env;
        public CategoriesController(AppDbContext db, IWebHostEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            List<Category> categories = await _db.Categories.ToListAsync();
            return View(categories);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Category category)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            bool isExist = await _db.Categories.AnyAsync(x => x.Name == category.Name);
            if (isExist)
            {
                ModelState.AddModelError("Title", "This category is already exist");
                return View();
            }
            await _db.Categories.AddAsync(category);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Category dbService = await _db.Categories.FirstOrDefaultAsync(x => x.Id == id);
            if (dbService == null)
            {
                return BadRequest();
            }
            return View(dbService);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Category service)
        {
            if (id == null)
            {
                return NotFound();
            }
            Category dbCategory = await _db.Categories.FirstOrDefaultAsync(x => x.Id == id);
            if (dbCategory == null)
            {
                return BadRequest();
            }
            if (!ModelState.IsValid)
            {
                return View(dbCategory);
            }
            bool isExist = await _db.Categories.AnyAsync(x => x.Name == service.Name && x.Id != id);
            if (isExist)
            {
                ModelState.AddModelError("Title", "This category is already exist");
                return View(dbCategory);
            }
            dbCategory.Name = service.Name;
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Activity(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Category category = await _db.Categories.FirstOrDefaultAsync(x => x.Id == id);
            if (category == null)
            {
                return BadRequest();
            }
            if (category.IsDeactive)
            {
                category.IsDeactive = false;
            }
            else
            {
                category.IsDeactive = true;

            }
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");

        }
    }
}
