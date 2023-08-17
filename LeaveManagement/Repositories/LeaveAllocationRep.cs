using LeaveManagement.Contracts;
using LeaveManagement.Data;
using Microsoft.AspNetCore.Identity;

namespace LeaveManagement.Repositories
{
    public class LeaveAllocationRep : GenericRepository<LeaveAllocation>, ILeaveAllocationRepo
    {
        private readonly UserManager<Employee> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ILeaveTypeRepository _leaveTypeRepository;

      
        public LeaveAllocationRep(ApplicationDbContext context, UserManager<Employee> userManager, 
            RoleManager<IdentityRole> roleManager, ILeaveTypeRepository leaveTypeRepository) : base(context)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _leaveTypeRepository = leaveTypeRepository;
        }

        public Task LeaveAllocation(int leaveTypeId)
        {
            throw new NotImplementedException();
        }
    }
}
