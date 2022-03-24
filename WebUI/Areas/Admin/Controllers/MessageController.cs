using Business.Concrete;
using DataAccess.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MessageController : Controller
    {
        Message2Manager message2Manager = new Message2Manager(new EfMessage2Repository());

        private readonly UserManager<AppUser> _userManager;

        public MessageController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Inbox()
        {
            var userName = User.Identity.Name;
            var user = await _userManager.FindByNameAsync(userName);

            var messages = message2Manager.GetInboxListByWriter(user.Id);

            ViewBag.MessageCount = messages.Count();

            return View(messages);
        }

        public async Task<IActionResult> Sendbox()
        {
            var userName = User.Identity.Name;
            var user = await _userManager.FindByNameAsync(userName);

            var messages = message2Manager.GetSendboxListByWriter(user.Id);

            ViewBag.MessageCount = messages.Count();

            return View(messages);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(string email, string subject, string detail)
        {
            var userName = User.Identity.Name;
            var user = await _userManager.FindByNameAsync(userName);

            Message2 message = new Message2();

            var receiver = await _userManager.FindByEmailAsync(email);

            message.SenderID = user.Id;
            message.Status = true;
            message.CreatedDate = DateTime.Now;
            message.Subject = subject;
            message.Detail = detail;
            message.ReceiverID = receiver.Id;

            message2Manager.Insert(message);

            return RedirectToAction("Sendbox", "Message");
        }
    }
}
