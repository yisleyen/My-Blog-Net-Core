using Business.Abstract;
using Business.Concrete;
using Business.ValidationRules;
using ClosedXML.Excel;
using DataAccess.EntityFramework;
using Entity.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : Controller
    {
        BlogManager blogManager = new BlogManager(new EfBlogRepository());
        WriterManager writerManager = new WriterManager(new EfWriterRepository());

        public IActionResult Index(int page = 1)
        {
            var blogs = blogManager.GetAll().ToPagedList(page, 12);

            return View(blogs);
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

                return RedirectToAction("Index", "Blog");
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

            return RedirectToAction("Index", "Blog");
        }

        public IActionResult ExportExcelFile()
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Bloglar");
                worksheet.Cell(1, 1).Value = "ID";
                worksheet.Cell(1, 2).Value = "Title";

                int RowCount = 2;

                foreach (var item in blogManager.GetAll())
                {
                    worksheet.Cell(RowCount, 1).Value = item.Id;
                    worksheet.Cell(RowCount, 2).Value = item.Title;
                    RowCount++;
                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Blogs.xlsx");
                }
            }
        }
    }
}
