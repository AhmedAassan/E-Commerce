using Ecommerce.BL.Interface;
using Ecommerce.BL.Models;
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
    public class OrderProductRep : IOrderProductRep
    {
        private readonly ProductContext db;

        public OrderProductRep(ProductContext db)
        {
            this.db = db;
        }
        public void Create(int orderId, int productid)
        {
            var data = new OrderProduct() { OrderId = orderId, ProductId = productid };
            db.OrderProduct.Add(data);
            db.SaveChanges();
        }

        public void Delete(OrderProduct opj)
        {
            db.OrderProduct.Remove(opj);
            db.SaveChanges();
        }

        public void Edit(OrderProduct opj)
        {
            db.Entry(opj).State = EntityState.Modified;
            db.SaveChanges();
        }

        public IEnumerable<OrderProduct> Get()
        {
            var data = db.OrderProduct.Select(a => a);
            return data;
        }

        public OrderProduct GetById(int id)
        {
            throw new NotImplementedException();
        }

        //public OrderProduct GetById(int id)
        //{
        //    var data = db.OrderProduct.Where(a => a.OrderId == id);
        //    return data;
        //}
    }
}
