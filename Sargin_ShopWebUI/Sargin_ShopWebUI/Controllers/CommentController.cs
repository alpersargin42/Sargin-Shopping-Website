using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BussinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;

namespace Sargin_ShopWebUI.Controllers
{
    public class CommentController : Controller
    {
        CommentManager cm = new CommentManager((new EfCommentRepository()));
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult PartialAddComment(Comment c)
        {
            c.CommentDate=DateTime.Parse(DateTime.Now.ToShortDateString());
            c.CommentStatus = true;
            c.ProductID = 15;
            cm.CommentAdd(c);
            return PartialView();
        }

        public PartialViewResult CommentListByProduct(int id)
        {
            var values=cm.GetList(id);
            return PartialView(values);
        }
    }
}
