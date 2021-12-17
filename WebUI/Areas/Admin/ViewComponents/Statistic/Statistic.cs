using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WebUI.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic : ViewComponent
    {
        Context context = new Context();

        public IViewComponentResult Invoke()
        {
            string apiKey = "0b03a2b2220bbc502e877d0bcec5aa09";
            string connectionLink = "http://api.openweathermap.org/data/2.5/weather?q=Istanbul&mode=xml&lang=tr&units=metric&appid=" + apiKey;
            XDocument Hava = XDocument.Load(connectionLink);

            var heat = Hava.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            var icon = Hava.Descendants("weather").ElementAt(0).Attribute("icon").Value;

            ViewBag.Icon = "http://openweathermap.org/img/w/" + icon + ".png";
            ViewBag.Heat = heat;

            ViewBag.BlogCount = context.Blogs.Count();
            ViewBag.CommentCount = context.Comments.Count();
            ViewBag.ContactCount = context.Contacts.Count();

            return View();
        }
    }
}
