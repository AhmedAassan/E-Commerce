using Ecommerce.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.BL.Interface
{
    public interface ICustomerRep
    {
        IEnumerable<Customer> Get();
        Customer GetById(int id);
        void Create(Customer opj);
        void Edit(Customer opj);
        void Delete(Customer opj);
    }
}

