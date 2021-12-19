using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eUniversity.WebUI.Models.Teachers
{
    public class TeachersListViewModel
    {
        public List<TeacherViewModel> Teachers { get; set; }
        public string SearchedUserName { get; set; }
    }
}
