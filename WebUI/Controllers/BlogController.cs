using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public class BlogController : Controller
    {
        BlogManager blogManager = new BlogManager(new EfBlogRepository());

        public IActionResult Index()
        {
            var blogList = blogManager.GetAllWithCategory();

            return View(blogList);
        }

        public IActionResult BlogDetails(int id)
        {
            ViewBag.BlogId = id;

            var blog = blogManager.GetById(id);

            return View(blog);
        }
    }
}
