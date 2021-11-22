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

        [Authorize]
        public IActionResult Index()
        {
            var userMail = User.Identity.Name;

            Context c = new Context();

            var userName = c.Writers.Where(x => x.Email == userMail).Select(y => y.Name).FirstOrDefault();

            ViewBag.Name = userName;

            return View();
        }

        [AllowAnonymous]
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

        [AllowAnonymous]
        [HttpGet]
        public IActionResult EditProfile()
        {
            var writer = writerManager.GetById(4);

            return View(writer);
        }

        [AllowAnonymous]
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
