using Hotel.EntityLayer.Concrete;
using System.ComponentModel.DataAnnotations;

namespace Hote.WebUI.Dtos.RegisterDto
{
    public class CreateNewUserDto
    {
        [Required(ErrorMessage ="Name space is required!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Surname space is required!")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Username space is required!")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password space is required!")]
        public string City { get; set; }

        [Required(ErrorMessage = "Mail space is required!")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Password space is required!")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password space is required!")]
        [Compare("Password",ErrorMessage ="Passwords are not matched!")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Work Department is required!")]
        public string WorkDepartment { get; set; }
        public string ImageUrl { get; set; }


    }
}
