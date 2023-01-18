using Ecommerce.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.BL.Interface
{
    public interface IProductRep
    {
        IEnumerable<Product> Get();
        Product GetById(int id);
        void Create(Product opj);
        void Edit(Product opj);
        void Delete(Product opj);
    }
}
