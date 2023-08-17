using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagement.Controllers
{
    //[Authorize(Roles ="Developer")]
    public class EmployeesController : Controller
    {
        private readonly UserManager<EmployeesController> _userManager;

        public EmployeesController(UserManager<EmployeesController> userManager)
        {
            this._userManager = userManager;
        }
        
        /*public IActionResult Index()
        {
            var emp = await _userManager.GetUserAsync();
            

        } */
    }
}
