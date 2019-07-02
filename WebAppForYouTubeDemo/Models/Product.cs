using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppForYouTubeDemo.Models
{
    public class Product
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Product Name is Required")]
        [Display(Name = "Product Name")]
        public string Name { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter suitable price!")]
        public int Price { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int Quantity { get; set; }

        [Display(Name = "Brand")]
        public int BrandId { get; set; }
        public Brand brandObj { get; set; }
    }

    public class Brand
    {
        public int id { get; set; }

        [Display(Name = "Brand Name")]
        public string Name { get; set; }

        public string Address { get; set; }
        public string Country { get; set; }
    }
}