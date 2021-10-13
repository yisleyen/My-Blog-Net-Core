using Business.Concrete;
using DataAccess.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public class NewsletterController : Controller
    {
        NewsletterManager newsletterManager = new NewsletterManager(new EfNewsletterRepository());

        [HttpGet]
        public PartialViewResult Subscribe()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult Subscribe(Newsletter newsletter)
        {
            newsletter.Status = true;
            newsletter.CreatedDate = DateTime.Now;
            newsletterManager.Insert(newsletter);
            return PartialView();
        }
    }
}
