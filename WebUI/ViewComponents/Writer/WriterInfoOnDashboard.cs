using Business.Abstract;
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
        WriterManager writerManager = new WriterManager(new EfWriterRepository());

        public IViewComponentResult Invoke()
        {
            var userMail = User.Identity.Name;
            var user = writerManager.GetWriterByFilter(userMail);

            var writer = writerManager.GetById(user[0].Id);

            return View(writer);
        }
    }
}
