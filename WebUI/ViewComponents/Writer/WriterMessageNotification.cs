using Business.Abstract;
using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.ViewComponents.Writer
{

    public class WriterMessageNotification : ViewComponent
    {
        Message2Manager messageManager = new Message2Manager(new EfMessage2Repository());
        WriterManager writerManager = new WriterManager(new EfWriterRepository());

        public IViewComponentResult Invoke()
        {
            var userMail = User.Identity.Name;
            var user = writerManager.GetWriterByFilter(userMail);

            var messages = messageManager.GetInboxListByWriter(user[0].Id);

            ViewBag.TotalMessageCount = messages.Count;

            return View(messages);
        }
    }
}
