using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class NotificationController : Controller
    {
        NotificationManager notificationManager = new NotificationManager(new EfNotificationRepository());

        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult List()
        {
            var notifications = notificationManager.GetAll();

            return View(notifications);
        }
    }
}
