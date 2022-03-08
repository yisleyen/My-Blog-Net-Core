using DataAccess.Concrete;
using Entity.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WebUI.Models;

namespace WebUI.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserSignInViewModel userSignInViewModel)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(userSignInViewModel.UserName, userSignInViewModel.Password, false, true);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Dashboard");
                }
            }

            return View();
        }

        //[HttpPost]
        //public async Task<IActionResult> Index(Writer writer)
        //{
        //    Context context = new Context();

        //    var loginValue = context.Writers.FirstOrDefault(x => x.Email == writer.Email && x.Password == writer.Password);

        //    if (loginValue != null) // login işlemi başarılı
        //    {
        //        var claims = new List<Claim>
        //        {
        //            new Claim(ClaimTypes.Name, writer.Email)
        //        };

        //        var userIdentity = new ClaimsIdentity(claims, "a");

        //        ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(userIdentity);

        //        await HttpContext.SignInAsync(claimsPrincipal);

        //        return RedirectToAction("Index", "Dashboard");
        //    }
        //    else // login işlemi başarısız
        //    {
        //        return View();
        //    }

        //}
    }
}
