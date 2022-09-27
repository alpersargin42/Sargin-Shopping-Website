using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using Newtonsoft.Json;
using Sargin_ShopWebUI.Models;

namespace Sargin_ShopWebUI.Controllers
{
    public class Advertiser2Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AdvertiserListt()
        {
            var jsonAdvertisers = JsonConvert.SerializeObject(advertisers);
            return Json(jsonAdvertisers);
        }

        public IActionResult GetAdvertiserByID(int aid)
        {
            var findadvertiser = advertisers.FirstOrDefault(x=>x.Id==aid);
            var jsonadvertisers = JsonConvert.SerializeObject(findadvertiser);
            return Json(jsonadvertisers);
        }

        [HttpPost]
        public IActionResult AddAdvertiser(AdvertiserClass w)
        {
            advertisers.Add(w);
            var jsonadvertisers = JsonConvert.SerializeObject(w);
            return Json(jsonadvertisers);
        }

        public IActionResult DeleteAdvertiser(int id)
        {
            var advertiser = advertisers.FirstOrDefault(x=>x.Id==id);
            advertisers.Remove(advertiser);
            return Json(advertiser);
        }

        public IActionResult UpdateAdvertiser(AdvertiserClass w)
        {
            var advertiser = advertisers.FirstOrDefault(x=>x.Id==w.Id);
            advertiser.Name = w.Name;
            var jsonAdvertiser = JsonConvert.SerializeObject(w);
            return Json(jsonAdvertiser);
        }

        public static List<AdvertiserClass> advertisers = new List<AdvertiserClass>
        {
            new AdvertiserClass
            {
                Id = 1,
                Name = "Alper"
            },
            new AdvertiserClass
            {
                Id = 2,
                Name = "Abduş"
            },
            new AdvertiserClass
            {
                Id = 3,
                Name = "Veli"
            }
        };
    }
}
