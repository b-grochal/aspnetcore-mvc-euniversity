using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eUniversity.WebUI.Models.Courses
{
    public class CoursesListViewModel
    {
        public List<CourseViewModel> Courses { get; set; }
        public string SearchedName { get; set; }
    }
}
