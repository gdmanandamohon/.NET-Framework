using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ASPAngularFiltering.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }

        
        public int DepartmentID { get; set; }

        [Required(ErrorMessage = "Please set a FullName of the User")]
        [StringLength(50, ErrorMessage = "Full Name not exit 50 characters")]
        [RegularExpression(@"[A-Z a-z]{1,32}", ErrorMessage = "only character are allowded")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Please set a UserName")]
        [StringLength(10, MinimumLength = 3, ErrorMessage = "Invalid UserName minimum length 3 character")]
        
        [Display(Name = "UserName")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please set Password for the User")]
        [StringLength(150, MinimumLength = 3, ErrorMessage = "Invalid Password minimum length 3 character ")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

       
        [NotMapped]
        [Display(Name = "New Password")]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Invalid Password minimum length 3 character")]
        public string NewPassword { get; set; }

        [NotMapped]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("NewPassword")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Invalid Password minimum length 3 character")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Please set a Email of the User")]
        [StringLength(40, MinimumLength = 4, ErrorMessage = "Invalid Email minimum length 4 character")]

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Contact Number")]
        //[Phone("ContactNo")]
        [StringLength(20, ErrorMessage = "Invalid ContactNumber")]
        //[RegularExpression(@"^\d{1,15}$", ErrorMessage = "Please enter up to 15 digits for a contact number")]
        [DataType(DataType.PhoneNumber)]
        public string ContactNo { get; set; }

        [StringLength(50, ErrorMessage = "Invalid Address")]
        [Display(Name = "Address")]
        public string Address { get; set; }

        //[Required(ErrorMessage = "Please set Designation for the User")]
        [StringLength(20, ErrorMessage = "Invalid Designation")]
        [Display(Name = "Designation")]
        public string Designation { get; set; }

        [Required(ErrorMessage = "Please set Role for the User")]
        [Display(Name = "Role")]
        public int Role { get; set; }
    }
}