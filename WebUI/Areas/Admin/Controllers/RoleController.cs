using Entity.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models;

namespace WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RoleController : Controller
    {
        private readonly RoleManager<AppRole> _roleManager;

        public RoleController(RoleManager<AppRole> roleManager)
        {
            _roleManager = roleManager;
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
    }
}
