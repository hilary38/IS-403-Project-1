using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Project_1_IS_403.Models
{
    public class User
    {
        [Key]
        [DisplayName("User ID")]
        [Required(ErrorMessage = "A user ID is required")]
        public int userId { get; set; }

        [DisplayName("User email")]
        [EmailAddress]
        [Required(ErrorMessage = "A user email is required")]
        public string userEmail { get; set; }

        [DisplayName("User Password")]
        [Required(ErrorMessage = "A user password is required")]
        public string userPassword { get; set; }

        [DisplayName("First Name")]
        [Required(ErrorMessage = "A first name is required")]
        public string userFirstName { get; set; }

        [DisplayName("Last Name")]
        [Required(ErrorMessage = "A last name is required")]
        public string userLastName { get; set; }

    }
}