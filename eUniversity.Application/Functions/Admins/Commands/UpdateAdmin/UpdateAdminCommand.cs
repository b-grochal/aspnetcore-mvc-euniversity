using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace eUniversity.Application.Functions.Admins.Commands.UpdateAdmin
{
    public class UpdateAdminCommand : IRequest
    {
        public int AdminId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
