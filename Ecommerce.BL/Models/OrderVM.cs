using Ecommerce.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.BL.Models
{
    public class OrderVM
    {
        public int Id { get; set; }
        public DateTime OrderTime { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public ICollection<int> ProductId { get; set; }
        public ICollection<OrderProduct> OrderProduct { get; set; }
    }
}
