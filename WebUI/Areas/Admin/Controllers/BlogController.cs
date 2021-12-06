using Business.Concrete;
using ClosedXML.Excel;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;
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

        public IActionResult Index(int page = 1)
        {
            var blogs = blogManager.GetAll().ToPagedList(page, 12);

            return View(blogs);
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
