using eUniversity.Application.Contracts.Infrastructure.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace eUniversity.Application.Functions.Auth.Commands.Logout
{
    public class LogoutCommandHandler : IRequestHandler<LogoutCommand>
    {
        private readonly IAuthService _authService;

        public LogoutCommandHandler(IAuthService authService)
        {
            _authService = authService;
        }

        public async Task<Unit> Handle(LogoutCommand request, CancellationToken cancellationToken)
        {
            await _authService.Logout();

            return Unit.Value;
        }
    }
}
