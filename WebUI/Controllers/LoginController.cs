using DataAccess.Concrete;
using Entity.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(Writer writer)
        {
            Context context = new Context();

            var loginValue = context.Writers.FirstOrDefault(x => x.Email == writer.Email && x.Password == writer.Password);

            if (loginValue != null) // login işlemi başarılı
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, writer.Email)
                };

                var userIdentity = new ClaimsIdentity(claims, "a");

                ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(userIdentity);

                await HttpContext.SignInAsync(claimsPrincipal);

                return RedirectToAction("Index", "Dashboard");
            }
            else // login işlemi başarısız
            {
                return View();
            }

        }
    }
}
