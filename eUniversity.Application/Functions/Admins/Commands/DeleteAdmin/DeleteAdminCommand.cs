using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace eUniversity.Application.Functions.Admins.Commands.DeleteAdmin
{
    public class DeleteAdminCommand : IRequest
    {
        public int AdminId { get; set; }
    }
}
