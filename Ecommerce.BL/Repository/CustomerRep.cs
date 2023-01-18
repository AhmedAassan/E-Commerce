using Ecommerce.BL.Interface;
using Ecommerce.DAL.Database;
using Ecommerce.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.BL.Repository
{
    public class CustomerRep : ICustomerRep
    {
        private readonly ProductContext db;

        public CustomerRep(ProductContext db)
        {
            this.db = db;
        }

        public void Create(Customer opj)
        {
            var data = db.Customer.Add(opj);
            db.SaveChanges();
        }

        public void Delete(Customer opj)
        {
            db.Customer.Remove(opj);
            db.SaveChanges();
        }

        public void Edit(Customer opj)
        {
            db.Entry(opj).State = EntityState.Modified;
            db.SaveChanges();
        }

        public IEnumerable<Customer> Get()
        {
            var data = db.Customer.Select(a => a);
            return data;
        }

        public Customer GetById(int id)
        {
            var data = db.Customer.Include("Order").Where(a => a.Id == id).FirstOrDefault();
            return data;
        }
    }
}
