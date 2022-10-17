using Fiorella.DAL;
using Fiorella.Helpers;
using Fiorella.Models;
using Fiorella.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorella.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;
       
        public HomeController(AppDbContext db)
        {
            _db = db;
            
        }
        public async Task<IActionResult> Index()
        {
            HomeVM homeVM = new HomeVM
            {
                SliderImages = await _db.SliderImages.ToListAsync(),
                Slider = await _db.Sliders.FirstOrDefaultAsync(),
                Categories = await _db.Categories.Where(x => !x.IsDeactive).ToListAsync(),
                Products = await _db.Products.Where(x => !x.IsDeactive).ToListAsync()
            };
            return View(homeVM);
        }
        public async Task<IActionResult> GlobalSearch(string key)
        {
            List<Product> products = await _db.Products.Where(x => x.Name.Contains(key)).ToListAsync();
            return PartialView("_ProductsSearchPartial", products);
        }

        public async Task<IActionResult> Error()
        {
            return View();
        }
        
        public async Task<IActionResult> Subscribe(string email)
        {
            if (!User.Identity.IsAuthenticated)
            {
                if (!Helper.IsValidEmail(email))
                {
                    return Content("Bu email adres deyil");
                }
                bool isExist = await _db.Subscribes.AnyAsync(x => x.Email == email);
                if (isExist)
                {
                    return Content("Bu email artiq abune olub");
                }
                await _db.Subscribes.AddAsync(new Subscribe { Email = email });
                await _db.SaveChangesAsync();
            }
            else
            {
                AppUser appUser=await _db.Users.FirstOrDefaultAsync(x=>x.UserName==User.Identity.Name);
                bool isExist = await _db.Subscribes.AnyAsync(x => x.Email == appUser.Email);
                if (isExist)
                {
                    return Content("Bu email artiq abune olub");
                }
                await _db.Subscribes.AddAsync(new Subscribe { Email =appUser.Email });
                await _db.SaveChangesAsync();
            }

            return Content("Tebrikler siz abune oldunuz");
        }
        
    }
}
