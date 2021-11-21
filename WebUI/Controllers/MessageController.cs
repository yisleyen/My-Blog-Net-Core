using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    [AllowAnonymous]
    public class MessageController : Controller
    {
        Message2Manager messageManager = new Message2Manager(new EfMessage2Repository());

        public IActionResult List()
        {
            var messages = messageManager.GetInboxListByWriter(4);

            return View(messages);
        }

        public IActionResult MessageDetails(int id)
        {
            var messaga = messageManager.GetById(id);

            return View(messaga);
        }
    }
}
