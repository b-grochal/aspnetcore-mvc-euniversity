using eUniversity.Application.Contracts.Infrastructure.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace eUniversity.Application.Functions.Admins.Commands.DeleteAdmin
{
    public class DeleteAdminCommandHandler : IRequestHandler<DeleteAdminCommand>
    {
        private readonly IAdminRepository _adminRepository;

        public DeleteAdminCommandHandler(IAdminRepository adminRepository)
        {
            _adminRepository = adminRepository;
        }   

        public async Task<Unit> Handle(DeleteAdminCommand request, CancellationToken cancellationToken)
        {
            var adminToDelete = await _adminRepository.GetByIdAsync(request.AdminId);

            await _adminRepository.DeleteAsync(adminToDelete);

            return Unit.Value;
        }
    }
}
