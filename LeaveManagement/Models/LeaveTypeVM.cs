using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("Leave Type")]
        public string Name { get; set; }
        [Required]
        [DisplayName("Default Number of Days")]
        public int DefaultDays { get; set; }


    }
}
