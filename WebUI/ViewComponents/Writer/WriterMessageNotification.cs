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
        MessageManager messageManager = new MessageManager(new EfMessageRepository());

        public IViewComponentResult Invoke()
        {
            var messages = messageManager.GetInboxListByWriter("me@yusufisleyen.com");

            ViewBag.TotalMessageCount = messages.Count;

            return View(messages);
        }
    }
}
