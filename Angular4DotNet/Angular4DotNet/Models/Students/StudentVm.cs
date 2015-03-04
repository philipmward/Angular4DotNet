﻿using System.ComponentModel.DataAnnotations;

namespace Angular4DotNet.Models.Students
{
    public class StudentVm
    {
        [Required(ErrorMessage = "Please enter an Email Address")]
        [RegularExpression(@"^[a-zA-Z0-9'._%+-]+@[a-zA-Z0-9-][a-zA-Z0-9.-]*\.[a-zA-Z]{2,9}$", ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter a First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter a Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter a Password")]
        public string Password { get; set; }
    }
}