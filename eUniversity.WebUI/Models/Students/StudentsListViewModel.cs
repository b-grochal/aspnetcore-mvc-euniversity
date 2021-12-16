using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eUniversity.WebUI.Models.Students
{
    public class StudentsListViewModel
    {
        public List<StudentViewModel> Students { get; set; }
        public string SearchedUserName { get; set; }
    }
}
