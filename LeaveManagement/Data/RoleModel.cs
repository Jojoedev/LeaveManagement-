using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Data
{
    
    public class RoleModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name ="Role Name")]
        public string RoleName { get; set; }
    }
}
