using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUniversity.Application.Functions.Teachers.Queries.GetTeachersList
{
    public class GetTeachersListQuery : IRequest<TeachersListDto>
    {
        public string SearchedUserName { get; set; }
    }
}
