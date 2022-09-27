using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BussinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;

namespace Sargin_ShopWebUI.Controllers
{
    public class DashboardController : Controller
    {
        ProductManager pm = new ProductManager(new EfProductRepository());
        public IActionResult Index()
        {
            Context c = new Context();
            var username = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var adverid = c.Advertisers.Where(x => x.AdvertiserMail == usermail).Select(y => y.AdvertiserID)
                .FirstOrDefault();

            ViewBag.v1 = c.Pruducts.Count().ToString();
            ViewBag.v2 = c.Pruducts.Where(x => x.AdvertiserID == adverid).Count().ToString();
            return View();
        }
    }
}
