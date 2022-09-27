using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BussinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Sargin_ShopWebUI.ViewComponents.Advertiser
{
    public class AdvertiserNotification:ViewComponent
    {
        NotificationManager pm = new NotificationManager(new EfNotificationRepository());

        public IViewComponentResult Invoke()
        {
            var values = pm.GetList();
            return View(values);
        }
    }
}
