using AutoMapper;
using eUniversity.Application.Contracts.Infrastructure.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace eUniversity.Application.Functions.Admins.Queries.GetAdminsList
{
    public class GetAdminsListQueryHandler : IRequestHandler<GetAdminsListQuery, AdminsListDto>
    {
        private readonly IAdminRepository _adminRepository;
        private readonly IMapper _mapper;

        public GetAdminsListQueryHandler(IAdminRepository adminRepository, IMapper mapper)
        {
            _adminRepository = adminRepository;
            _mapper = mapper;
        }

        public async Task<AdminsListDto> Handle(GetAdminsListQuery request, CancellationToken cancellationToken)
        {
            var admins = await _adminRepository.GetAllByUsernameAsync(request.SearchedUsername);
            return new AdminsListDto
            {
                Admins = _mapper.Map<List<AdminDto>>(admins),
                SearchedUsername = request.SearchedUsername
            };
        }
    }
}
