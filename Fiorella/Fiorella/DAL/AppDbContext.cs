using Fiorella.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Fiorella.DAL
{
    public class AppDbContext: IdentityDbContext<AppUser>
    {
        internal IEnumerable<object> tblUsers;

        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderImage> SliderImages { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }
    }
}
