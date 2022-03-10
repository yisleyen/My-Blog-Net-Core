using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public class DashboardController : Controller
    {
        BlogManager blogManager = new BlogManager(new EfBlogRepository());
        CategoryManager categoryManager = new CategoryManager(new EfCategoryRepository());
        WriterManager writerManager = new WriterManager(new EfWriterRepository());

        Context c = new Context();

        [AllowAnonymous]
        public IActionResult Index()
        {
            var userName = User.Identity.Name;
            var userMail = c.Users.Where(x => x.UserName == userName).Select(y => y.Email).FirstOrDefault();
            var user = writerManager.GetWriterByFilter(userMail);

            ViewBag.TotalBlogCount = blogManager.GetAll().Count();
            ViewBag.WriterBlogCount = blogManager.GetAllByWriter(user[0].Id).Count();
            ViewBag.CategoryCount = categoryManager.GetAll().Count();

            return View();
        }
    }
}
