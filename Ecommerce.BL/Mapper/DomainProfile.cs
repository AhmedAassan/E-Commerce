using AutoMapper;
using Ecommerce.BL.Models;
using Ecommerce.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.BL.Mapper
{
    public class DomainProfile : Profile
    {
        public DomainProfile()
        {
            CreateMap<Product, ProductVM>();
            CreateMap<ProductVM, Product>();


            CreateMap<Order, OrderVM>();
            CreateMap<OrderVM, Order>();


            CreateMap<Customer, CustomerVM>();
            CreateMap<CustomerVM, Customer>();


            CreateMap<OrderProduct, OrderProductVM>();
            CreateMap<OrderProductVM, OrderProduct>();
        }
    }
}
