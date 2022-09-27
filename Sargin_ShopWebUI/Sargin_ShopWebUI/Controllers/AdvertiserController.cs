using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BussinessLayer.Concrete;
using BussinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using Sargin_ShopWebUI.Models;

namespace Sargin_ShopWebUI.Controllers
{
    public class AdvertiserController : Controller
    {
        private AdvertiserManager wm = new AdvertiserManager(new EfAdvertiserRepository());

        private readonly UserManager<AppUser> _userManager;

        public AdvertiserController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [Authorize]
        public IActionResult Index()
        {
            var usermail = User.Identity.Name;
            ViewBag.v = usermail;
            Context c = new Context();
            var advertisername = c.Advertisers.Where(x => x.AdvertiserMail == usermail).Select(y => y.AdvertiserName).FirstOrDefault();
            ViewBag.s = advertisername;
            return View();
        }

        public IActionResult AdvertiserProfile()
        {
            return View();
        }
        public IActionResult AdvertiserMail()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult Test()
        {
            return View();
        }
        [AllowAnonymous]
        public PartialViewResult AdvertiserNavbarPartial()
        {
            var usermail = User.Identity.Name;
            ViewBag.v = usermail;
            Context c = new Context();
            var advertisername = c.Advertisers.Where(x => x.AdvertiserMail == usermail).Select(y => y.AdvertiserName).FirstOrDefault();
            ViewBag.s = advertisername;
            return PartialView();
        }
        [AllowAnonymous]
        public PartialViewResult AdvertiserFooterResult()
        {
            return PartialView();
        }

        [HttpGet]
        public IActionResult AdvertiserEditProfile()
        {
            Context c = new Context();
            var username = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName==username).Select(y=>y.Email).FirstOrDefault();
            UserManager userManager = new UserManager(new EfUserRepository());
            //var advertiserID = c.Advertisers.Where(x => x.AdvertiserMail == usermail).Select(y => y.AdvertiserID)
            //    .FirstOrDefault();
            //var advertiservalues = wm.GetById(advertiserID);
            //return View(advertiservalues);
            //var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var id = c.Users.Where(x => x.Email == usermail).Select(y => y.Id).FirstOrDefault();
            var values = userManager.GetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult AdvertiserEditProfile(Advertiser p)
        {
            AdvertiserValidator al = new AdvertiserValidator();
            ValidationResult results = al.Validate(p);
            if (results.IsValid)
            {
                wm.TUpdate(p);
                return RedirectToAction("Index","Dashboard");
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

        [AllowAnonymous]
        [HttpGet]
        public IActionResult AdvertiserAdd()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult AdvertiserAdd(AddProfileImage p)
        {
            Advertiser w = new Advertiser();
            if (p.AdvertiserImage != null)
            {
                var extension = Path.GetExtension(p.AdvertiserImage.FileName);
                var newimagename = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/AdvertiserImage", newimagename);
                var stream = new FileStream(location,FileMode.Create);
                p.AdvertiserImage.CopyTo(stream);
                w.AdvertiserImage = newimagename;
            }

            w.AdvertiserMail = p.AdvertiserMail;
            w.AdvertiserPassword = p.AdvertiserPassword;
            w.AdvertiserPassword1 = p.AdvertiserPassword1;
            w.AdvertiserName = p.AdvertiserName;
            w.AdvertiserStatus = true;
            w.AdvertiserAbout = p.AdvertiserAbout;
            wm.TAdd(w);
            return RedirectToAction("Index", "Dashboard");
        }

    }
}
