using Fiorella.DAL;
using Fiorella.Models;
using Fiorella.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorella.Controllers
{
    public class ProductsController : Controller
    {
        private readonly AppDbContext _db;
        public ProductsController(AppDbContext db)
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
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null)
            {
                return View("Error");
            }
            Product product = await _db.Products.Include(x=>x.ProductDetail).FirstOrDefaultAsync(x => x.Id == id);

            if (product == null)
            {
                return View("Error");
            }
            return View(product);
        }
    }
}
