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
    public class OrderRep : IOrderRep
    {
        private readonly ProductContext db;

        public OrderRep(ProductContext db)
        {
            this.db = db;
        }


        public int Create(Order opj)
        {
            var data = db.Order.Add(opj);
            db.SaveChanges();
            return opj.Id;
        }

        public void Delete(Order opj)
        {
            db.Order.Remove(opj);
            db.SaveChanges();
        }

        public IEnumerable<Order> Get()
        {
            var data = db.Order.Include("Customer").Include(a=> a.OrderProduct).ThenInclude(a=> a.Product)
                       .Select(a => a);
            return data;
        }

        public Order GetById(int id)
        {
            var data = db.Order.Include("Customer").Where(a => a.Id == id).FirstOrDefault();
            return data;
        } 
    }
}
