using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CommentController : Controller
    {
        CommentManager commentManager = new CommentManager(new EfCommetRepository());

        public IActionResult Index()
        {
            var comments = commentManager.GetAll();

            return View(comments);
        }

        public IActionResult Delete(int id)
        {
            return View();
        }
    }
}
