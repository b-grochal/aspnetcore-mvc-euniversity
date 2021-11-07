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
    public class GetAdminsListQueryHandler : IRequestHandler<GetAdminsListQuery, List<AdminViewModel>>
    {
        private readonly IAdminRepository _adminRepository;
        private readonly IMapper _mapper;

        public GetAdminsListQueryHandler(IAdminRepository adminRepository, IMapper mapper)
        {
            _adminRepository = adminRepository;
            _mapper = mapper;
        }

        public async Task<List<AdminViewModel>> Handle(GetAdminsListQuery request, CancellationToken cancellationToken)
        {
            var admins = await _adminRepository.GetAllAsync();
            return _mapper.Map<List<AdminViewModel>>(admins);
        }
    }
}
