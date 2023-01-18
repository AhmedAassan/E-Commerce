using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.DAL.Entities
{
    [Table("Order")]
    public class Order
    {
        public Order()
        {
            this.OrderTime = DateTime.Now;  
        }
        public int Id { get; set; }
        public DateTime OrderTime { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }


        public ICollection<OrderProduct> OrderProduct { get; set; }
    }
}
