using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Areas.Admin.ViewComponents.StatisticAdmin
{
    public class StatisticAdmin : ViewComponent
    {
        Context context = new Context();

        public IViewComponentResult Invoke()
        {
            ViewBag.AdminName = context.Admins.Where(x => x.Id == 1).Select(y => y.Name).FirstOrDefault();
            ViewBag.AdminImage = context.Admins.Where(x => x.Id == 1).Select(y => y.ImageUrl).FirstOrDefault();
            ViewBag.AdminDesc = context.Admins.Where(x => x.Id == 1).Select(y => y.ShortDescription).FirstOrDefault();

            return View();
        }
    }
}
