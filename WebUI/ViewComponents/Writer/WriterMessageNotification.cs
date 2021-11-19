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

        public IViewComponentResult Invoke()
        {
            var messages = messageManager.GetInboxListByWriter(4);

            ViewBag.TotalMessageCount = messages.Count;

            return View(messages);
        }
    }
}
