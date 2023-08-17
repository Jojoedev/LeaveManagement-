using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagement.Data
{
    public class Request
    {
        public int Id { get; set; }
        public string Description { get; set; }
        [Display(Name ="Request Date")]
        public DateTime RequestDate { get; set; }

        public int? Amount { get; set; }


        [Display(Name ="Source Document")]
        public string? Image { get; set; }

         [NotMapped]
        
        [Display(Name = "Upload File")]
        public IFormFile? ImageFile { get; set; }

        public int RequesterId { get; set; }
        public Requester? Requester { get; set; }

        
    }
}
