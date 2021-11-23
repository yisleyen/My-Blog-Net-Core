using Business.Abstract;
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
        WriterManager writerManager = new WriterManager(new EfWriterRepository());

        [AllowAnonymous]
        public IActionResult Index()
        {
            var blogList = blogManager.GetAllWithCategory();

            return View(blogList);
        }

        [AllowAnonymous]
        [Route("blog/{title}-{id}")]
        public IActionResult BlogDetails(int id)
        {
            ViewBag.BlogId = id;

            var blog = blogManager.GetById(id);

            ViewBag.WriterId = blog.WriterId;

            return View(blog);
        }

        public IActionResult WriterBlogList()
        {
            var userMail = User.Identity.Name;
            var user = writerManager.GetWriterByFilter(userMail);

            var blogList = blogManager.GetAllWithCategoryByWriter(user[0].Id);

            return View(blogList);
        }

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

        [HttpPost]
        public IActionResult Add(Blog blog)
        {
            var userMail = User.Identity.Name;
            var user = writerManager.GetWriterByFilter(userMail);

            BlogValidator blogValidator = new BlogValidator();
            ValidationResult validationResult = blogValidator.Validate(blog);

            if (validationResult.IsValid)
            {
                blog.WriterId = user[0].Id;
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

        public IActionResult Delete(int id)
        {
            var blog = blogManager.GetById(id);

            blogManager.Delete(blog);

            return RedirectToAction("WriterBlogList", "Blog");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryRepository());
            List<SelectListItem> categoryList = (from x in categoryManager.GetAll()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.Name,
                                                     Value = x.Id.ToString()
                                                 }).ToList();
            ViewBag.CategorySelectList = categoryList;

            var blog = blogManager.GetById(id);

            return View(blog);
        }

        [HttpPost]
        public IActionResult Edit(Blog blog)
        {
            BlogValidator blogValidator = new BlogValidator();
            ValidationResult validationResult = blogValidator.Validate(blog);

            if (validationResult.IsValid)
            {
                blog.Status = true;
                blogManager.Update(blog);

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
