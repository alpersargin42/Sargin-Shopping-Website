using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Sargin_ShopWebUI.Models;

namespace Sargin_ShopWebUI.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        //[HttpPost]
        //[AllowAnonymous]
        //public async Task<IActionResult> Index(Advertiser a)
        //{
        //    Context c = new Context();
        //    var datavalue = c.Advertisers.FirstOrDefault(x => x.AdvertiserMail == a.AdvertiserMail && x.AdvertiserPassword == a.AdvertiserPassword);
        //    if (datavalue!=null)
        //    {
        //        var claims = new List<Claim>
        //        {
        //            new Claim(ClaimTypes.Name, a.AdvertiserMail)
        //        };
        //        var useridentity = new ClaimsIdentity(claims,"a");
        //        ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
        //        await HttpContext.SignInAsync(principal);
        //        return RedirectToAction("Index","Dashboard");
        //    }
        //    else
        //    {
        //        return View();
        //    }
        //}

        [HttpPost]
        public async Task<IActionResult> Index(UserSıgnInViewModel p)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(p.username, p.password, false, true);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Dashboard");
                }
                else
                {
                    return RedirectToAction("Index","Login");
                }
            }

            return View();
        }

        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Login");
        }

    }
}

//Context c = new Context();
//var datavalue = c.Advertisers.FirstOrDefault(x => x.AdvertiserMail == a.AdvertiserMail && x.AdvertiserPassword == a.AdvertiserPassword);
//if (datavalue != null)
//{
//    HttpContext.Session.SetString("username", a.AdvertiserMail);
//    return RedirectToAction("Index", "Advertiser");
//}
//else
//{
//    return View();
//}

