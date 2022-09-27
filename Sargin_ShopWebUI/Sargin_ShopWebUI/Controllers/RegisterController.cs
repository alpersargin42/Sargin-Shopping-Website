using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using BussinessLayer.Concrete;
using BussinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc.Rendering;
using FluentValidation.Results;
using ValidationResult = FluentValidation.Results.ValidationResult;

namespace Sargin_ShopWebUI.Controllers
{
    public class RegisterController : Controller
    {
        private AdvertiserManager ad = new AdvertiserManager(new EfAdvertiserRepository());
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Advertiser a)
        {
            AdvertiserValidator Ava = new AdvertiserValidator();
            ValidationResult results = Ava.Validate(a);
            if (results.IsValid)
            {
                a.AdvertiserStatus = true;
                a.AdvertiserAbout = "Deneme";
                ad.AdvertiserAdd(a);
                return RedirectToAction("Index", "ProductC");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                }
            }

            return View();
        }
    }
}
