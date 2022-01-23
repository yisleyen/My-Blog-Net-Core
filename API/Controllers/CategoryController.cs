using Business.Concrete;
using DataAccess.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryRepository());

        [HttpGet]
        public IActionResult CategoryList()
        {
            var categoryList = categoryManager.GetAll();

            return Ok(categoryList);
        }

        [HttpPost]
        public IActionResult CategoryAdd(Category category)
        {
            category.Status = true;
            category.CreatedDate = DateTime.Now;
            categoryManager.Insert(category);

            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetCategoryById(int id)
        {
            var category = categoryManager.GetById(id);

            if (category == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(category);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult CategoryDelete(int id)
        {
            var category = categoryManager.GetById(id);

            if (category == null)
            {
                return NotFound();
            }
            else
            {
                categoryManager.Delete(category);
                return Ok(category);
            }
        }
    }
}
