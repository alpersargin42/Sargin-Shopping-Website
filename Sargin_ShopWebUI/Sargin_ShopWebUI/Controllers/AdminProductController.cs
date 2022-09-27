using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BussinessLayer.Concrete;
using DataAccessLayer.EntityFramework;

namespace Sargin_ShopWebUI.Controllers
{
    public class AdminProductController : Controller
    {
        private ProductManager c = new ProductManager(new EfProductRepository());

        public IActionResult Index()
        {
            var values = c.GetProductListWithCategory();
            return View(values);
        }
    }
}
