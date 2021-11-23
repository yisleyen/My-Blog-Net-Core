using Business.Abstract;
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
        WriterManager writerManager = new WriterManager(new EfWriterRepository());

        public IActionResult List()
        {
            var userMail = User.Identity.Name;
            var user = writerManager.GetWriterByFilter(userMail);

            var messages = messageManager.GetInboxListByWriter(user[0].Id);

            return View(messages);
        }

        public IActionResult MessageDetails(int id)
        {
            var messaga = messageManager.GetById(id);

            return View(messaga);
        }
    }
}
