using AutoMapper;
using eUniversity.Application.Contracts.Infrastructure.Repositories;
using eUniversity.Domain.Enitities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace eUniversity.Application.Functions.Admins.Commands.CreateAdmin
{
    public class CreateAdminCommandHandler : IRequestHandler<CreateAdminCommand, CreateAdminCommandResponse>
    {
        private readonly IAdminRepository _adminRepository;
        private readonly IMapper _mapper;

        public CreateAdminCommandHandler(IAdminRepository adminRepository, IMapper mapper)
        {
            _adminRepository = adminRepository;
            _mapper = mapper;
        }

        public async Task<CreateAdminCommandResponse> Handle(CreateAdminCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateAdminCommandValidator();
            var validatorResult = await validator.ValidateAsync(request);

            if (!validatorResult.IsValid)
                return new CreateAdminCommandResponse(validatorResult);

            var admin = _mapper.Map<Admin>(request);
            admin = await _adminRepository.AddAsync(admin);

            return new CreateAdminCommandResponse(admin.AdminId);
        }
    }
}
