using Ecommerce.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.BL.Interface
{
    public interface IOrderProductRep
    {
        IEnumerable<OrderProduct> Get();
        OrderProduct GetById(int id);
        void Create(int orderId, int productid);
        void Edit(OrderProduct opj);
        void Delete(OrderProduct opj);
    }
}
