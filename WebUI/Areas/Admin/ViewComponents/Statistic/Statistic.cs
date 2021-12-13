using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic : ViewComponent
    {
        Context context = new Context();

        public IViewComponentResult Invoke()
        {
            ViewBag.BlogCount = context.Blogs.Count();
            ViewBag.CommentCount = context.Comments.Count();
            ViewBag.ContactCount = context.Contacts.Count();

            return View();
        }
    }
}
