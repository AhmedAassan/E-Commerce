
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Ecommerce.Controllers
{
    public class HomeController : Controller
    {
        

        

        public IActionResult Index()
        {
            return View();
        }

       
    }
}