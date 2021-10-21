using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.ViewComponets.Comment
{
    public class CommentListByBlogId : ViewComponent
    {
        CommentManager commentManager = new CommentManager(new EfCommetRepository());

        public IViewComponentResult Invoke(int id)
        {
            var commentList = commentManager.GetAll(id);

            if (commentList.Count == 0)
            {
                ViewBag.Message = "Henüz yorum yapılmamış. İlk yorumu siz yapabilirsiniz.";
            }
            else
            {
                ViewBag.Message = null;
            }

            return View(commentList);
        }
    }
}
