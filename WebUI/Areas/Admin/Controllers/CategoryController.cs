using Business.Concrete;
using Business.ValidationRules;
using DataAccess.EntityFramework;
using Entity.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace WebUI.Areas.Admin.Controllers
{
    [AllowAnonymous]
    [Area("Admin")]
    public class CategoryController : Controller
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryRepository());

        public IActionResult Index(int page = 1)
        {
            var categoryList = categoryManager.GetAll().ToPagedList(page, 12);

            return View(categoryList);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Category category)
        {
            CategoryValidator categoryValidator = new CategoryValidator();
            ValidationResult validationResult = categoryValidator.Validate(category);

            if (validationResult.IsValid)
            {
                category.Status = true;
                category.CreatedDate = DateTime.Now;
                categoryManager.Insert(category);

                return RedirectToAction("Index", "Category");
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

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var category = categoryManager.GetById(id);

            categoryManager.Delete(category);

            return RedirectToAction("Index", "Category");
        }
    }
}
