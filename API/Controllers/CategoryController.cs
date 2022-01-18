using Business.Concrete;
using DataAccess.EntityFramework;
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
    }
}
