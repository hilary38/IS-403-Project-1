using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Project_1_IS_403.Models
{
    public class Question
    {
        [Key]
        [DisplayName("Question ID")]
        [Required(ErrorMessage = "A question ID is required")]
        public int questionID { get; set; }

        [DisplayName("Mission ID")]
        [Required(ErrorMessage = "A mission ID is required")]
        public int missID { get; set; }

        [DisplayName("User ID")]
        [Required(ErrorMessage = "A user ID is required")]
        public int userID { get; set; }

        [DisplayName("Question")]
        [Required(ErrorMessage = "A question is required")]
        public string question { get; set; }

        [DisplayName("Answer")]
        public string answer { get; set; }

    }
}