using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace eUniversity.Application.Functions.Admins.Queries.GetAdminDetail
{
    public class GetAdminDetailQuery : IRequest<AdminDetailsDto>
    {
        public int Id { get; set; }
    }
}
