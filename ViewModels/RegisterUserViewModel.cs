using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExamPortal.ViewModels
{
    public class RegisterUserViewModel
    {
        [Required]
        [Display(Name ="First Name")]
        [MinLength(3, ErrorMessage = "First Name should be at least 3 characters")]
        public string FirstName { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "Last Name should be at least 3 characters")]
        [Display(Name ="Last Name")]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Password and confirm Password do not match")]
        public string ConfirmPassword { get; set; }

        [EmailAddress]
        [Required]
        [Remote(action: "IsEmailInUse", controller: "Account")]
        public string Email { get; set; }

        [Required]
        [Display(Name ="Phone Number")]
        [Phone]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name ="Date of Birth")]
        public DateTime DOB { get; set; }

    }
}
