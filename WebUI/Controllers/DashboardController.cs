using Business.Concrete;
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

        [AllowAnonymous]
        public IActionResult Index()
        {
            ViewBag.TotalBlogCount = blogManager.GetAll().Count();
            ViewBag.WriterBlogCount = blogManager.GetAllByWriter(4).Count();
            ViewBag.CategoryCount = categoryManager.GetAll().Count();

            return View();
        }
    }
}
