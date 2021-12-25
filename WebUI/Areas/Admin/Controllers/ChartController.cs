using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Areas.Admin.Models;

namespace WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListByCategory()
        {
            List<Category> categories = new List<Category>();

            categories.Add(new Category
            {
                Name = "Teknoloji",
                Count = 6
            });
            categories.Add(new Category
            {
                Name = "Yazılım",
                Count = 13
            });
            categories.Add(new Category
            {
                Name = "Spor",
                Count = 7
            });
            categories.Add(new Category
            {
                Name = "Sanat",
                Count = 2
            });

            return Json(new { jsonlist = categories });
        }
    }
}
