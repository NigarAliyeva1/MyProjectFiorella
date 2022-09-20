using Fiorella.Models;
using Fiorella.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;
using System.Threading.Tasks;

namespace Fiorella.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public ProfileController(UserManager<AppUser> userManager,
                                 SignInManager<AppUser> signInManager,
                                 RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }
        public async Task<IActionResult> Index()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return NotFound();
            }
            else
            {
                AppUser appUser = await _userManager.FindByNameAsync(User.Identity.Name);
                if(appUser == null)
                {
                    return BadRequest();
                }
                ProfileVM profileVM = new ProfileVM
                {
                    Email=appUser.Email,
                    UserName=appUser.UserName,
                    FullName=appUser.FullName,
                    Image=appUser.Image
                };
                return View(profileVM);
            }
        }
    }
}
