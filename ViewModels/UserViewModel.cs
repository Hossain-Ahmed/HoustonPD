using System.ComponentModel.DataAnnotations;

namespace HoustonPD.ViewModels
{
    public class UserViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter name.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter name.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Please enter Email.")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail id is not valid")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter password.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Please re enter your password")]
        public string RepeatPassword { get; set; }
    }
}