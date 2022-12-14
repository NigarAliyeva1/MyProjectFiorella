using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Fiorella.ViewModels
{
    public class RegisterVM
    {
        [Required]
        public string FullName { get; set; }


        [Required]
        public string UserName { get; set; }

        public string Image { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
        
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        public IFormFile Photo { get; set; }



    }
}
