using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace eUniversity.Application.Functions.Admins.Commands.CreateAdmin
{
    public class CreateAdminCommand : IRequest<CreateAdminCommandResponse>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string ConfirmationPassword { get; set; }
    }
}
