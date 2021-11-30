using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace eUniversity.Application.Functions.Admins.Queries.GetAdminsList
{
    public class GetAdminsListQuery : IRequest<AdminsListDto>
    {
        public string SearchedUsername { get; set; }
    }
}
