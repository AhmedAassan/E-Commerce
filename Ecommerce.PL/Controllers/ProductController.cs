using AutoMapper;
using Ecommerce.BL.Interface;
using Ecommerce.BL.Models;
using Ecommerce.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRep product;
        private readonly IMapper mapper;

        public ProductController(IProductRep product, IMapper mapper)
        {
            this.product = product;
            this.mapper = mapper;
        }







        public IActionResult Index()
        {
            var data = product.Get();
            var model = mapper.Map<IEnumerable<ProductVM>>(data);
            return View(model);
        }



        public IActionResult Create()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult Create(ProductVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var data = mapper.Map<Product>(model);
                    product.Create(data);
                    return RedirectToAction("Index");
                }
                return View(model);
            }
            catch (Exception ex)
            {

                return View(model);
            }
         }

        public IActionResult Details(int id)
        {
            var data = product.GetById(id);
            var model = mapper.Map<ProductVM>(data);
            return View(model);
        }









        public IActionResult Edit(int id)
        {
            var data = product.GetById(id);
            var model = mapper.Map<ProductVM>(data);
            return View(model);
        }

       

        [HttpPost]
        public IActionResult Edit(ProductVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var data = mapper.Map<Product>(model);
                    product.Edit(data);
                    return RedirectToAction("Index");
                }
                return View(model);
            }
            catch (Exception)
            {

                return View(model);
            }
        }


        public IActionResult Delete(int id)
        {
            var data = product.GetById(id);
            var model = mapper.Map<ProductVM>(data);
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(ProductVM model)
        {
            try
            {
                var data = mapper.Map<Product>(model);
                product.Delete(data);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                return View(model);
            }
        }

    }
}
