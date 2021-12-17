using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eUniversity.WebUI.Models.Courses
{
    public class CreateCourseViewModel
    {
        [Required]
        [DisplayName("Name")]
        public string Name { get; set; }
        
        [Required]
        [DisplayName("Password")]
        public string Password { get; set; }

        [Required]
        [DisplayName("Confirm password")]
        [Compare(nameof(Password), ErrorMessage = "Passwords don't match.")]
        public string ConfirmationPassword { get; set; }

        [Required]
        [DisplayName("Subject")]
        public int SubjectId { get; set; }

        [Required]
        [DisplayName("Semester")]
        public int SemesterId { get; set; }

        [Required]
        [DisplayName("Degree")]
        public int DegreeId { get; set; }
    }
}