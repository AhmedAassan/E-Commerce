using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.BL.Models
{
    public class ProductVM
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "Name Required")]
        public string Name { get; set; }



        [Required(ErrorMessage = "Color Required")]
        public string Color { get; set; }


        [Required(ErrorMessage = "Size Required")]
        public string Size { get; set; }



        [Required(ErrorMessage = "Price Required")]
        public double Price { get; set; }



        [Required(ErrorMessage = "Quantity Required")]
        public int Quantity { get; set; }


        
        public string Description { get; set; }



        [Required(ErrorMessage = "ProductUser Required")]
        public string ProductUser { get; set; }
    }
}
