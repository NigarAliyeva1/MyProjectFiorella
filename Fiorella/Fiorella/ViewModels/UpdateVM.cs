using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Fiorella.ViewModels
{
    public class UpdateVM
    {
        [Required]
        public string FullName { get; set; }


        [Required]
        public string UserName { get; set; }


        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public IFormFile Photo { get; set; }


    }
}
