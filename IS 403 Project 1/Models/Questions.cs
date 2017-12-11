using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace IS_403_Project_1.Models
{
    public class Question
    {
        [Key]
        [DisplayName("Question ID")]
        [Required(ErrorMessage = "A question ID is required")]
        public int questionId { get; set; }

        [DisplayName("Mission ID")]
        [Required(ErrorMessage = "A mission ID is required")]
        public int missId { get; set; }

        [DisplayName("User ID")]
        [Required(ErrorMessage = "A user ID is required")]
        public int userId { get; set; }

        [DisplayName("Question")]
        [Required(ErrorMessage = "A question is required")]
        public string question { get; set; }

        [DisplayName("Answer")]
        public string answer { get; set; }

    }
}