using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
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

        private readonly UserManager<AppUser> _userManager;

        public DashboardController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var userName = User.Identity.Name;
            var user = await _userManager.FindByNameAsync(userName);

            ViewBag.TotalBlogCount = blogManager.GetAll().Count();
            ViewBag.WriterBlogCount = blogManager.GetAllByWriter(user.Id).Count();
            ViewBag.CategoryCount = categoryManager.GetAll().Count();

            return View();
        }
    }
}
