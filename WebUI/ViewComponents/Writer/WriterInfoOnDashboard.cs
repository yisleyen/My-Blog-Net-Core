using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.ViewComponents.Writer
{
    public class WriterInfoOnDashboard : ViewComponent
    {
        UserManager userManager = new UserManager(new EfUserRepository());

        Context c = new Context();

        public IViewComponentResult Invoke()
        {
            var userName = User.Identity.Name;
            var userId = c.Users.Where(x => x.UserName == userName).Select(y => y.Id).FirstOrDefault();

            var writer = userManager.GetById(userId);

            return View(writer);
        }
    }
}
