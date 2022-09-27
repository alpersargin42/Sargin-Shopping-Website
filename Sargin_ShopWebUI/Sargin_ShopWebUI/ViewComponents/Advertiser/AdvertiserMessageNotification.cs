using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BussinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Sargin_ShopWebUI.ViewComponents.Advertiser
{
    public class AdvertiserMessageNotification : ViewComponent
    {
        private Message2Manager mm = new Message2Manager(new EfMessage2Repository());
        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            var username = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var advertiserID = c.Advertisers.Where(x => x.AdvertiserMail == usermail).Select(y => y.AdvertiserID)
                .FirstOrDefault();
            var values = mm.GetInboxListByAdvertiser(advertiserID);
            return View(values);
        }
    }
}
