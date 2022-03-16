using Business.Abstract;
using Business.ValidationRules;
using DataAccess.Concrete;
using DataAccess.EntityFramework;
using Entity.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class WriterController : Controller
    {
        WriterManager writerManager = new WriterManager(new EfWriterRepository());

        private readonly UserManager<AppUser> _userManager;

        public WriterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var userMail = User.Identity.Name;
            var user = writerManager.GetWriterByFilter(userMail);
            ViewBag.Name = user[0].Name;

            return View();
        }

        public IActionResult Test()
        {
            return View();
        }

        public PartialViewResult NavBarPartial()
        {
            return PartialView();
        }

        public PartialViewResult FooterPartial()
        {
            return PartialView();
        }

        [HttpGet]
        public async Task<IActionResult> EditProfile()
        {
            var userName = User.Identity.Name;
            var writer = await _userManager.FindByNameAsync(userName);

            UserUpdateViewModel userUpdateViewModel = new()
            {
                Email = writer.Email,
                UserName = writer.UserName,
                NameSurname = writer.NameSurname
            };

            return View(userUpdateViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> EditProfile(UserUpdateViewModel userUpdateViewModel)
        {
            if (ModelState.IsValid)
            {
                var userName = User.Identity.Name;

                var writer = await _userManager.FindByNameAsync(userName);

                writer.NameSurname = userUpdateViewModel.NameSurname;
                writer.Email = userUpdateViewModel.Email;

                var result = await _userManager.UpdateAsync(writer);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Dashboard");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }

            return View();
        }
    }
}
