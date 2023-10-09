using System.ComponentModel.DataAnnotations;

namespace Hote.WebUI.Dtos.ServiceDto
{
    public class CreateServiceDto
    {
        [Required(ErrorMessage = "Please enter Service icon link")]
        public string ServiceIcon { get; set; }

        [Required(ErrorMessage = "Please enter Service Title ")]
        [StringLength(100, ErrorMessage = "Service Title can be max 100 character")]
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
