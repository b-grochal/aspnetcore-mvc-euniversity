using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eUniversity.WebUI.Models.Courses
{
    public class CoursesListForStudentViewModel
    {
        public List<CourseForStudentViewModel> Courses { get; set; }
        public string SearchedName { get; set; }
    }
}
