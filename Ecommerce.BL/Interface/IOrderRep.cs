using Ecommerce.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.BL.Interface
{
    public interface IOrderRep
    {
        IEnumerable<Order> Get();
        Order GetById(int id);
        int Create(Order opj);
        //void Edit(Product opj);
        void Delete(Order opj);
    }
}
