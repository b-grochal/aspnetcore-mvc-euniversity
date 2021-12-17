using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eUniversity.WebUI.Models.Courses
{
    public class EditCourseViewModel
    {
        [Required]
        public int CourseId { get; set; }

        [Required]
        [DisplayName("Name")]
        public string Name { get; set; }

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
