using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUniversity.Application.Functions.Teachers.Queries.GetTeachersList
{
    public class TeachersListDto
    {
        public List<TeacherDto> Teachers { get; set; }
        public string SearchedUsername { get; set; }
    }
}
