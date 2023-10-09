using Hote.WebUI.Dtos.Role;
using Hotel.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Hote.WebUI.Controllers
{
    public class RoleAssignController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;
    public RoleAssignController(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            var value = _userManager.Users.ToList();
            return View(value);
        }
        [HttpGet]
        public async Task<IActionResult> AssignRole(int id)
        {
            var user = _userManager.Users.FirstOrDefault(x => x.Id == id);
            TempData["userid"] = user.Id;
            var roles = _roleManager.Roles.ToList();
            var userRoles = await _userManager.GetRolesAsync(user);
            List<RoleAssignDto> roleAssignDtos = new List<RoleAssignDto>();
            foreach (var item in roles)
            {
                RoleAssignDto roleAssignDto = new RoleAssignDto();
                roleAssignDto.RoleID = item.Id;
                roleAssignDto.RoleName = item.Name;
                roleAssignDto.RoleExist = userRoles.Contains(item.Name);
                roleAssignDtos.Add(roleAssignDto);
            }
            return View(roleAssignDtos);

        }
        [HttpPost]
        public async Task<IActionResult> AssignRole(List<RoleAssignDto> roleAssignDto)
        {
            var userid = (int)TempData["userid"];
            var user = _userManager.Users.FirstOrDefault(x=>x.Id == userid);
            foreach (var item in roleAssignDto)
            {
                if (item.RoleExist)
                {
                    await _userManager.AddToRoleAsync(user, item.RoleName);
                }
                else
                {
                    await _userManager.RemoveFromRoleAsync(user, item.RoleName);
                }
            }
            return RedirectToAction("Index");

        }
    }
}
