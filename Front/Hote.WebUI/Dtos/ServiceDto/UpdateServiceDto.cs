using System.ComponentModel.DataAnnotations;

namespace Hote.WebUI.Dtos.ServiceDto
{
    public class UpdateServiceDto
    {

        public int ServiceID { get; set; }

        [Required(ErrorMessage = "Please enter Service icon link")]
        public string ServiceIcon { get; set; }

        [Required(ErrorMessage = "Please enter Service Title ")]
        [StringLength(100, ErrorMessage = "Service Title can be max 100 character")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter Service Description ")]
        [StringLength(500, ErrorMessage = "Service Description can be max 100 character")]
        public string Description { get; set; }
    }
}
