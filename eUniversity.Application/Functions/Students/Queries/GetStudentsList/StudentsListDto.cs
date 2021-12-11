using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUniversity.Application.Functions.Students.Queries.GetStudentsList
{
    public class StudentsListDto
    {
        public List<StudentDto> Students { get; set; }
        public string SearchedUsername { get; set; }
    }
}
