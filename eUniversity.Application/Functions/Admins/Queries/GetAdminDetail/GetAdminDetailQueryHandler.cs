using AutoMapper;
using eUniversity.Application.Contracts.Infrastructure.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace eUniversity.Application.Functions.Admins.Queries.GetAdminDetail
{
    public class GetAdminDetailQueryHandler : IRequestHandler<GetAdminDetailQuery, AdminDetailViewModel>
    {
        private readonly IAdminRepository _adminRepository;
        private readonly IMapper _mapper;

        public GetAdminDetailQueryHandler(IAdminRepository adminRepository, IMapper mapper)
        {
            _adminRepository = adminRepository;
            _mapper = mapper;
        }

        public async Task<AdminDetailViewModel> Handle(GetAdminDetailQuery request, CancellationToken cancellationToken)
        {
            var admin = await _adminRepository.GetByIdAsync(request.Id);
            
            var adminDetail = _mapper.Map<AdminDetailViewModel>(admin);

            return adminDetail; 
        }
    }
}
