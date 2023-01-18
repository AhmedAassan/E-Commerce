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
    public class ProductRep : IProductRep
    {
        private readonly ProductContext db;

        public ProductRep(ProductContext db)
        {
            this.db = db;
        }



        public IEnumerable<Product> Get()
        {
            var data = db.Product.Select(a => a);
            return data;
        }



        public Product GetById(int id)
        {
            var data = db.Product.Where(a => a.Id == id).FirstOrDefault();
            return data;
        }


        public void Create(Product opj)
        {
            var data = db.Product.Add(opj);
            db.SaveChanges();
        }

        public void Edit(Product opj)
        {
            db.Entry(opj).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(Product opj)
        {
            db.Product.Remove(opj);
            db.SaveChanges();
        }

       

       
    }
}
