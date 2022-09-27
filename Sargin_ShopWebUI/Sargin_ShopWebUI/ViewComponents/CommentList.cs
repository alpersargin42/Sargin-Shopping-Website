using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Sargin_ShopWebUI.Models;

namespace Sargin_ShopWebUI.ViewComponents
{
    public class CommentList :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentvalues = new List<UserComment>
            {
                new UserComment
                {
                    ID = 1,
                    Username = "Alper"
                },
                new UserComment
                {
                    ID = 2,
                    Username = "Abduş"
                },
                new UserComment
                {
                    ID = 3,
                    Username = "Ayşegül"
                },

            };
            return View(commentvalues);
        }
    }
}
