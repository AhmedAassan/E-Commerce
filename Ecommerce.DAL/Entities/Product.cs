using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.DAL.Entities
{
    [Table("Product")]
    public class Product
    {
        public int Id { get; set; }


        [Required]
        public string Name { get; set; }



        [Required]
        public string Color { get; set; }


        [Required]
        public string Size { get; set; }



        [Required]
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }

        public string ProductUser { get; set; }


        public ICollection<OrderProduct> OrderProduct { get; set; }

    }
}
