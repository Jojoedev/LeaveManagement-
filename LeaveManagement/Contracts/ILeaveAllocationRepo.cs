using LeaveManagement.Data;
using LeaveManagement.Repository;

namespace LeaveManagement.Contracts
{
    public interface ILeaveAllocationRepo : IGenericRepository<LeaveAllocation>
    {
        Task LeaveAllocation(int leaveTypeId);


    }
}
