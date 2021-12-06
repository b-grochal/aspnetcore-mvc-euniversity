using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eUniversity.WebUI.Models.Admins
{
    public class AdminsListViewModel
    {
        public List<AdminViewModel> Admins { get; set; }
        public string SearchedUserName { get; set; }
    }
}
