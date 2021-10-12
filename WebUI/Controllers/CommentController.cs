using Business.Concrete;
using DataAccess.EntityFramework;
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

        public PartialViewResult AddCommentByBlogId()
        {
            return PartialView();
        }
    }
}
