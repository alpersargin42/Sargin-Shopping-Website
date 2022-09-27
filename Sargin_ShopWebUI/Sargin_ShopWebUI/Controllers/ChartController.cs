using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sargin_ShopWebUI.Models;

namespace Sargin_ShopWebUI.Controllers
{
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CategoryChart()
        {
            List<CategoryClass> list = new List<CategoryClass>();
            list.Add(new CategoryClass
            {
                categoryname = "beyazeşya",
                categorycount = 10
            });
            list.Add(new CategoryClass
            {
                categoryname = "bilgisayar",
                categorycount = 15
            });
            list.Add(new CategoryClass
            {
                categoryname = "telefon",
                categorycount = 8
            });
            return Json(new { jsonlist = list });
        }
    }
}
