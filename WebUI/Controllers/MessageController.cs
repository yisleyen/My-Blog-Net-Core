using Business.Abstract;
using Business.Concrete;
using DataAccess.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public class MessageController : Controller
    {
        Message2Manager messageManager = new Message2Manager(new EfMessage2Repository());

        private readonly UserManager<AppUser> _userManager;

        public MessageController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> List()
        {
            var userName = User.Identity.Name;
            var user = await _userManager.FindByNameAsync(userName);

            var messages = messageManager.GetInboxListByWriter(user.Id);

            return View(messages);
        }

        public IActionResult MessageDetails(int id)
        {
            var messaga = messageManager.GetById(id);

            return View(messaga);
        }

        [HttpGet]
        public IActionResult SendMessage()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> SendMessage(string email, string subject, string detail)
        {
            var userName = User.Identity.Name;
            var user = await _userManager.FindByNameAsync(userName);

            Message2 message = new Message2();

            var receiver = await _userManager.FindByEmailAsync(email);

            message.SenderID = user.Id;
            message.ReceiverID = 2;
            message.Status = true;
            message.CreatedDate = DateTime.Now;
            message.Subject = subject;
            message.Detail = detail;
            message.ReceiverID = receiver.Id;

            messageManager.Insert(message);

            return RedirectToAction("List");
        }

        [HttpGet]
        public async Task<IActionResult> Sendbox()
        {
            var userName = User.Identity.Name;
            var user = await _userManager.FindByNameAsync(userName);

            var messages = messageManager.GetSendboxListByWriter(user.Id);

            return View(messages);
        }
    }
}
