using AutoMapper;
using Ecommerce.BL.Interface;
using Ecommerce.BL.Models;
using Ecommerce.DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Ecommerce.Controllers
{
    public class OrderController : Controller
    {
        private readonly IMapper mapper;
        private readonly IProductRep product;
        private readonly IOrderRep order;
        private readonly ICustomerRep customer;
        private readonly IOrderProductRep orderProduct;

        public OrderController(IMapper mapper,
                               IProductRep product,
                               IOrderRep order,
                               ICustomerRep customer, 
                               IOrderProductRep orderProduct)
        {
            this.mapper = mapper;
            this.product = product;
            this.order = order;
            this.customer = customer;
            this.orderProduct = orderProduct;
        }






        public IActionResult Index()
        {
            var data = order.Get();
            var model = mapper.Map<ICollection<OrderVM>>(data);
            return View(model);
        }


        public IActionResult Create()
        {
            var Product = product.Get();
            var Customer = customer.Get();
            ViewBag.Product = new SelectList(Product, "id", "Name");
            ViewBag.Customer = new SelectList(Customer, "id", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult Create(OrderVM model)
        {
            var data = mapper.Map<Order>(model);
            order.Create(data);

            foreach (var item in model.ProductId)
            {
                orderProduct.Create(data.Id, item);
            }


            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var data = order.GetById(id);
            order.Delete(data);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var data = order.GetById(id);
            var model = mapper.Map<OrderVM>(data);
            return View(model);
        }
    }
}
