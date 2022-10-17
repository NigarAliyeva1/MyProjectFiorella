using Fiorella.Models;
using System.Collections.Generic;

namespace Fiorella.ViewModels
{
    public class HomeVM
    {
        public Slider Slider { get; set; }
        public List<SliderImage> SliderImages { get; set; }
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
        public Subscribe Subscribe { get; set; }


    }
}
