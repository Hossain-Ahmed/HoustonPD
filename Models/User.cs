using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HoustonPD.Models
{
    public class User
    {
        public string Id { get; set; }
        [Required(ErrorMessage = "Please enter name.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter Email.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter password.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Please re enter your password")]
        public string RepeatPassword { get; set; }
    }
}