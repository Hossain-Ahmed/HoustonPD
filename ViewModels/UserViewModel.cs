using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HoustonPD.ViewModels
{
    public class UserViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string RepeatPassword { get; set; }
    }
}