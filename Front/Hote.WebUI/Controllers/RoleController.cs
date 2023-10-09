using Hote.WebUI.Dtos.Role;
using Hotel.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Hote.WebUI.Controllers
{
    public class RoleController : Controller
    {
        private readonly RoleManager<AppRole> _roleManager;

        public RoleController(RoleManager<AppRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            var value = _roleManager.Roles.ToList();
            return View(value);
        }
        [HttpGet]
        public IActionResult AddRole()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddRole(AddRoleDto addRoleDto)
        {
            AppRole appRole = new AppRole
            {
                Name = addRoleDto.RoleName
            };
            var result = await _roleManager.CreateAsync(appRole);
            if(result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        public async Task<IActionResult> DeleteRole(int id)
        {
            var value = _roleManager.Roles.FirstOrDefault(x=> x.Id == id);
            await _roleManager.DeleteAsync(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> UpdateRole(int id) 
        {
            var value = _roleManager.Roles.FirstOrDefault(x=>x.Id == id);
            UpdateRoleDto updateRoleDto = new UpdateRoleDto()
            {
                RoleID = value.Id,
                RoleName = value.Name
            };
            return View(updateRoleDto);
        
        }
        [HttpPost]
        public async Task<IActionResult> UpdateRole(UpdateRoleDto updateRoleDto)
        { 
            var value = _roleManager.Roles.FirstOrDefault(x=>x.Id==updateRoleDto.RoleID);
            value.Name = updateRoleDto.RoleName;
            await _roleManager.UpdateAsync(value);
            return RedirectToAction("Index");
        }
    }
}
