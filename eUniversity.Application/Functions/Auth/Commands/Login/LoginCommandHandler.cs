using eUniversity.Application.Contracts.Infrastructure.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace eUniversity.Application.Functions.Auth.Commands.Login
{
    public class LoginCommandHandler : IRequestHandler<LoginCommand, LoginCommandResponse>
    {
        private readonly IAuthService _authService;

        public LoginCommandHandler(IAuthService authService)
        {
            _authService = authService;
        }

        public async Task<LoginCommandResponse> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            var validator = new LoginCommandValidator();
            var validatiorResult = await validator.ValidateAsync(request);

            if (!validatiorResult.IsValid)
                return new LoginCommandResponse(validatiorResult);

            var loginResult = await _authService.Login(request.Email, request.Password);

            if (!loginResult)
                return new LoginCommandResponse("Invalid login attempt.", loginResult);

            return new LoginCommandResponse("Successfully logged in.", loginResult);
        }
    }
}
