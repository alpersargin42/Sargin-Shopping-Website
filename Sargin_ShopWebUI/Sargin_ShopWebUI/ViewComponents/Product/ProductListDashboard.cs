using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BussinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Sargin_ShopWebUI.ViewComponents.Product
{
    public class ProductListDashboard : ViewComponent
    {
        private ProductManager pm = new ProductManager(new EfProductRepository());

        public IViewComponentResult Invoke()
        {
            var values = pm.GetProductListWithCategory();
            return View(values);
        }
    }
}
