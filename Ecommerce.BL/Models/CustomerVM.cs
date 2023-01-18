using Ecommerce.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.BL.Models
{
    public class CustomerVM
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public ICollection<Order>? Order { get; set; }
    }
}
