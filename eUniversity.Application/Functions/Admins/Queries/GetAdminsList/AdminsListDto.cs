using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUniversity.Application.Functions.Admins.Queries.GetAdminsList
{
    public class AdminsListDto
    {
        public List<AdminDto> Admins { get; set; }
        public string SearchedUsername { get; set; }
    }
}
