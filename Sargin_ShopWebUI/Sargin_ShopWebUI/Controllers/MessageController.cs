using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BussinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Sargin_ShopWebUI.Controllers
{
    [AllowAnonymous]
    public class MessageController : Controller
    {
        Message2Manager mm = new Message2Manager(new EfMessage2Repository());

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult InBox()
        {
            Context c = new Context();
            var username = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var advertiserID = c.Advertisers.Where(x => x.AdvertiserMail == usermail).Select(y => y.AdvertiserID)
                .FirstOrDefault();
            var values = mm.GetInboxListByAdvertiser(advertiserID);
            return View(values);
        }
        public IActionResult SendBox()
        {
            Context c = new Context();
            var username = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var advertiserID = c.Advertisers.Where(x => x.AdvertiserMail == usermail).Select(y => y.AdvertiserID)
                .FirstOrDefault();
            var values = mm.GetSendboxListWithMessageByAdvertiser(advertiserID);
            return View(values);
        }
        public IActionResult MessageDetails(int id)
        {
            var value = mm.GetById(id);
            return View(value);
        }
        public IActionResult MessageDetails2(int id)
        {
            var value = mm.GetById(id);
            return View(value);
        }
        [HttpGet]
        public IActionResult SendMessage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SendMessage(Message2 p)
        {
            Context c = new Context();
            var username = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var advertiserID = c.Advertisers.Where(x => x.AdvertiserMail == usermail).Select(y => y.AdvertiserID)
                .FirstOrDefault();
            p.SenderID = advertiserID;
            p.ReceiverID = 26;
            p.MessageStatus = true;
            p.MessageDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            mm.TAdd(p);
            return RedirectToAction("InBox");
        }
    }
}
