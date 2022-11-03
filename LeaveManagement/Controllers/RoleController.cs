using LeaveManagement.Constants;
using LeaveManagement.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace LeaveManagement.Controllers
{
    [Authorize(Roles = "Administrator, Accounts")]
    public class RoleController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        

        public RoleController(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
            
        }
        
        public IActionResult Index()
        {
          var roleList  = _roleManager.Roles.ToList();
            return View(roleList);
        }

        public IActionResult Create()
        {
            return View(new IdentityRole());
        }

        [HttpPost]
        public async Task<IActionResult> Create(IdentityRole role)
        {
            await _roleManager.CreateAsync(role);
            return RedirectToAction("Index");
        } 






       /* public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        
        public async Task<IActionResult> Create(RoleModel roleModel)
        {
            var existingRole = await _roleManager.RoleExistsAsync(roleModel.RoleName);

            if (!existingRole)
            {
               await _roleManager.CreateAsync(new IdentityRole(roleModel.RoleName));
                
            }
            return View("Index");
            
            
        }*/

        
        
    }
}
