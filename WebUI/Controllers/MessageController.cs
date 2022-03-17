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
    [AllowAnonymous]
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
    }
}
