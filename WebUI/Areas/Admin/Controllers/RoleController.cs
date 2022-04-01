using Entity.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models;

namespace WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RoleController : Controller
    {
        private readonly RoleManager<AppRole> _roleManager;
        private readonly UserManager<AppUser> _userManager;

        public RoleController(RoleManager<AppRole> roleManager, UserManager<AppUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var roles = _roleManager.Roles.ToList();

            return View(roles);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(RoleViewModel roleViewModel)
        {
            if (ModelState.IsValid)
            {
                AppRole appRole = new AppRole
                {
                    Name = roleViewModel.Name
                };

                var result = await _roleManager.CreateAsync(appRole);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }

            return View(roleViewModel);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var roles = _roleManager.Roles.FirstOrDefault(x => x.Id == id);

            var result = await _roleManager.DeleteAsync(roles);

            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var roles = _roleManager.Roles.FirstOrDefault(x => x.Id == id);

            UpdateRoleViewModel updateRoleViewModel = new UpdateRoleViewModel();

            updateRoleViewModel.Id = roles.Id;
            updateRoleViewModel.Name = roles.Name;

            return View(updateRoleViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Update(UpdateRoleViewModel updateRoleViewModel)
        {
            var roles = _roleManager.Roles.FirstOrDefault(x => x.Id == updateRoleViewModel.Id);

            roles.Name = updateRoleViewModel.Name;

            var result = await _roleManager.UpdateAsync(roles);

            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult List()
        {
            var users = _userManager.Users.ToList();

            return View(users);
        }

        [HttpGet]
        public async Task<IActionResult> Assign(int id)
        {
            var user = _userManager.Users.FirstOrDefault(x => x.Id == id);

            var roles = _roleManager.Roles.ToList();

            TempData["UserId"] = user.Id;

            var userRoles = await _userManager.GetRolesAsync(user);

            List<RoleAssignViewModel> assignments = new List<RoleAssignViewModel>();

            foreach (var item in roles)
            {
                RoleAssignViewModel roleAssignViewModel = new RoleAssignViewModel();
                roleAssignViewModel.Id = item.Id;
                roleAssignViewModel.Name = item.Name;
                roleAssignViewModel.Exists = userRoles.Contains(item.Name);

                assignments.Add(roleAssignViewModel);
            }

            return View(assignments);
        }

        [HttpPost]
        public async Task<IActionResult> Assign(List<RoleAssignViewModel> roleAssignViewModels)
        {
            var userid = (int)TempData["UserId"];

            var user = _userManager.Users.FirstOrDefault(x => x.Id == userid);

            foreach (var item in roleAssignViewModels)
            {
                if (item.Exists)
                {
                    await _userManager.AddToRoleAsync(user, item.Name);
                }
                else
                {
                    await _userManager.RemoveFromRoleAsync(user, item.Name);
                }
            }

            return RedirectToAction("List");
        }
    }
}
