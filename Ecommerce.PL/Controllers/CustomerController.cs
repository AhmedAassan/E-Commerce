using AutoMapper;
using Ecommerce.BL.Interface;
using Ecommerce.BL.Models;
using Ecommerce.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Controllers
{
    public class CustomerController : Controller
    {
        private readonly IMapper mapper;
        private readonly ICustomerRep customer;

        public CustomerController(IMapper mapper, ICustomerRep customer)
        {
            this.mapper = mapper;
            this.customer = customer;
        }
        public IActionResult Index()
        {
            var data = customer.Get();
            var model = mapper.Map<IEnumerable<CustomerVM>>(data);
            return View(model);
        }


        public IActionResult Create()
        {
           
            return View();
        }
        [HttpPost]
        public IActionResult Create(CustomerVM model)
        {

            
                    var data = mapper.Map<Customer>(model);
                    customer.Create(data);
                    return RedirectToAction("Index");
                
        }


        public IActionResult Details(int id)
        {
            var data = customer.GetById(id);
            var model = mapper.Map<CustomerVM>(data);
            return View(model);
        }

        public IActionResult Edit(int id)
        {
            var data = customer.GetById(id);
            var model = mapper.Map<CustomerVM>(data);
            return View(model);
        }


        [HttpPost]
        public IActionResult Edit(CustomerVM model )
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var data = mapper.Map<Customer>(model);
                    customer.Edit(data);
                    return RedirectToAction("Index");
                }
                return View(model);
            }
            catch (Exception ex)
            {

                return View(model);
            }
        }


        public IActionResult Delete(int id)
        {
            var data = customer.GetById(id);
            customer.Delete(data);
            return RedirectToAction("Index");
        }
    }
}
