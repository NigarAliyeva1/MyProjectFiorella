using System.ComponentModel.DataAnnotations;

namespace Fiorella.ViewModels
{
    public class ProfileVM
    {
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Image { get; set; }
        public string Email { get; set; }
    }
}
