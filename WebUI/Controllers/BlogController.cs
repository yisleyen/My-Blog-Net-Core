using Business.Concrete;
using Business.ValidationRules;
using DataAccess.EntityFramework;
using Entity.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public class BlogController : Controller
    {
        BlogManager blogManager = new BlogManager(new EfBlogRepository());

        [AllowAnonymous]
        public IActionResult Index()
        {
            var blogList = blogManager.GetAllWithCategory();

            return View(blogList);
        }

        [AllowAnonymous]
        public IActionResult BlogDetails(int id)
        {
            ViewBag.BlogId = id;

            var blog = blogManager.GetById(id);

            ViewBag.WriterId = blog.WriterId;

            return View(blog);
        }

        [AllowAnonymous]
        public IActionResult WriterBlogList()
        {
            var blogList = blogManager.GetAllByWriter(4);

            return View(blogList);
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Add()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryRepository());
            List<SelectListItem> categoryList = (from x in categoryManager.GetAll()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.Name,
                                                     Value = x.Id.ToString()
                                                 }).ToList();
            ViewBag.CategorySelectList = categoryList;

            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult Add(Blog blog)
        {
            BlogValidator blogValidator = new BlogValidator();
            ValidationResult validationResult = blogValidator.Validate(blog);

            if (validationResult.IsValid)
            {
                blog.WriterId = 4;
                blog.Status = true;
                blog.CreatedDate = DateTime.Now;
                blogManager.Insert(blog);

                return RedirectToAction("WriterBlogList", "Blog");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();
        }
    }
}
