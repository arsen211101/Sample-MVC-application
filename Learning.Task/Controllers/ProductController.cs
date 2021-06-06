using Learning.Task.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Learning.Task.Controllers
{
    public class ProductController : Controller
    {
        [HttpGet]
        [Route("Product/CreateProduct")]
        public ViewResult CreateProduct()
        {
            return View(new Product());
        }

        [HttpPost]
        public ViewResult CreateProduct(Product product)
        {
            return View();
        }
    }
}
