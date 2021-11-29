using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace eUniversity.Application.Functions.Auth.Commands.Login
{
    public class LoginCommand : IRequest<LoginCommandResponse>
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
