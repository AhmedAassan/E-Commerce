using Ecommerce.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.DAL.Database
{
    public class ProductContext :DbContext
    {



        public ProductContext(DbContextOptions<ProductContext> opj) : base(opj)
        {

        }




        public DbSet<Product> Product { get; set; }
        public DbSet<Customer> Customer { get; set; }

        public DbSet<Order> Order { get; set; }

        public DbSet<OrderProduct> OrderProduct { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderProduct>().HasKey(a => new { a.OrderId, a.ProductId });
            modelBuilder.Entity<OrderProduct>().HasOne(a => a.Order).WithMany(a => a.OrderProduct).HasForeignKey(a => a.OrderId);
            modelBuilder.Entity<OrderProduct>().HasOne(a => a.Product).WithMany(a => a.OrderProduct).HasForeignKey(a => a.ProductId);

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("server=.;database=Ecommerce;Integrated Security=true;MultipleActiveResultSets=true");
        //}
    }
}
