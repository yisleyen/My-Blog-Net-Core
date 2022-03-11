using Business.Abstract;
using Business.ValidationRules;
using DataAccess.Concrete;
using DataAccess.EntityFramework;
using Entity.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
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
        public IActionResult EditProfile()
        {
            Context c = new Context();
            var userName = User.Identity.Name;
            var userMail = c.Users.Where(x => x.UserName == userName).Select(y => y.Email).FirstOrDefault();
            var user = writerManager.GetWriterByFilter(userMail);
            var writer = writerManager.GetById(user[0].Id);

            return View(writer);
        }

        [HttpPost]
        public IActionResult EditProfile(AddProfileImage p)
        {
            Writer writer = new Writer();

            if (p.Image != null)
            {
                WriterValidator writerValidator = new WriterValidator();
                ValidationResult validationResult = writerValidator.Validate(writer);

                if (validationResult.IsValid)
                {
                    var extension = Path.GetExtension(p.Image.FileName);
                    var newImageName = Guid.NewGuid() + extension;
                    var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/", newImageName);
                    var stream = new FileStream(location, FileMode.Create);
                    p.Image.CopyTo(stream);

                    writer.Id = p.Id;
                    writer.Status = true;
                    writer.CreatedDate = DateTime.Now;
                    writer.Email = p.Email;
                    writer.Name = p.Name;
                    writer.Password = p.Password;
                    writer.ConfirmPassword = p.ConfirmPassword;
                    writer.About = p.About;
                    writer.Image = newImageName;
                    writerManager.Update(writer);

                    return RedirectToAction("Index", "Dashboard");
                }
                else
                {
                    foreach (var item in validationResult.Errors)
                    {
                        ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                    }
                }
            }
            

            return View();
        }
    }
}
