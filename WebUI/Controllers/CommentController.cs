using Business.Concrete;
using DataAccess.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public class CommentController : Controller
    {
        CommentManager commentManager = new CommentManager(new EfCommetRepository());

        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult CommentListByBlogId()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult AddCommentByBlogId(Comment comment)
        {
            comment.Status = true;
            comment.CreatedDate = DateTime.Now;
            comment.BlogId = 3;
            commentManager.Insert(comment);
            return PartialView();
        }
    }
}
