using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BussinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using EntityLayer.Concrete;

namespace Sargin_ShopWebUI.ViewComponents.Category
{
    public class CategoryList:ViewComponent
    {
        private CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        private ProductManager pm = new ProductManager(new EfProductRepository());
        

        public IViewComponentResult Invoke()
        {
            EntityLayer.Concrete.Category c = new EntityLayer.Concrete.Category();
            var values = cm.GetList();
            ViewBag.v = pm.GetList().Count();
            return View(values);
        }
    }
}
