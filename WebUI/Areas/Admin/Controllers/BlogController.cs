using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : Controller
    {
        BlogManager blogManager = new BlogManager(new EfBlogRepository());

        public IActionResult Index(int page = 1)
        {
            var blogs = blogManager.GetAll().ToPagedList(page, 12);

            return View(blogs);
        }
    }
}
