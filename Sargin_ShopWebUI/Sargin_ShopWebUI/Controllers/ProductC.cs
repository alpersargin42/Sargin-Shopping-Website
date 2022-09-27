using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks;
using BussinessLayer.Concrete;
using BussinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.ModelBinding.Metadata;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Sargin_ShopWebUI.Controllers
{
    
    public class ProductC : Controller
    {
        ProductManager pm = new ProductManager(new EfProductRepository());
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        private Pruduct p = new Pruduct();
        [AllowAnonymous]
        public IActionResult Index()
        {
            var values = pm.GetProductListWithCategory();
            return View(values);
        }
        [AllowAnonymous]
        public IActionResult ProductReadAll(int id)
        {
            ViewBag.i = id;
            var values = pm.GPruductByID(id);
            return View(values);
        }
        [AllowAnonymous]
        public IActionResult ProductListByAdvertiser()
        {
            Context c = new Context();
            var username = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var advertiserID = c.Advertisers.Where(x => x.AdvertiserMail == usermail).Select(y => y.AdvertiserID)
                .FirstOrDefault();
            var values= pm.Test(advertiserID);
            return View(values);
        }
        [HttpGet]
        public IActionResult ProductAdd()
        {
            p.ProductOffer = false;
            
            List<SelectListItem> categorycvalues = (from x in cm.GetList()
                select new SelectListItem
                {
                    Text = x.CategoryName,
                    Value = x.CategoryID.ToString()
                }).ToList();
            ViewBag.cv = categorycvalues;
            return View();
        }
        [HttpPost]
        public IActionResult ProductAdd(Pruduct p)
        {
            Context c = new Context();
            var username = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var advertiserID = c.Advertisers.Where(x => x.AdvertiserMail == usermail).Select(y => y.AdvertiserID)
                .FirstOrDefault();

            ProductValidator prv = new ProductValidator();
            ValidationResult results = prv.Validate(p);
            if (results.IsValid)
            {
                p.ProductStatus = true;
                p.AdvertiserID = advertiserID;
                pm.TAdd(p);
                return RedirectToAction("ProductListByAdvertiser", "ProductC");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();
        }

        public IActionResult DeleteProduct(int id)
        {
            var productvalue = pm.GetById(id);
            pm.TDelete(productvalue);
            return RedirectToAction("ProductListByAdvertiser");
        }
        [HttpGet]
        public IActionResult EditProduct(int id)
        {
            var productvalue = pm.GetById(id);
            List<SelectListItem> categorycvalues = (from x in cm.GetList()
                select new SelectListItem
                {
                    Text = x.CategoryName,
                    Value = x.CategoryID.ToString()
                }).ToList();
            ViewBag.cv = categorycvalues;
            return View(productvalue);
        }

        [HttpPost]
        public IActionResult EditProduct(Pruduct p)
        {
            Context c = new Context();
            var username = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var advertiserID = c.Advertisers.Where(x => x.AdvertiserMail == usermail).Select(y => y.AdvertiserID)
                .FirstOrDefault();
            p.AdvertiserID = advertiserID;
            p.ProductStatus = true;
            pm.TUpdate(p);
            return RedirectToAction("ProductListByAdvertiser");
        }
        [AllowAnonymous]
        public IActionResult Offer(int id)
        {
            var values = pm.GPruductByID(id);
            return View(values);
        }

        [AllowAnonymous]
        public IActionResult Kategorili(int id)
        {
            var values = pm.GetProductListWithCategory().Where(x=>x.CategoryID==id).ToList();
            return View(values);
        }

        public IActionResult SuccessSend()
        {
            return View();
        }
        public IActionResult SuccessSold()
        {
            return View();
        }
        public IActionResult FailSold()
        {
            return View();
        }
    }
}
