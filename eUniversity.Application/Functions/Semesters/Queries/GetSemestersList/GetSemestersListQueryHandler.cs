using AutoMapper;
using eUniversity.Application.Contracts.Infrastructure.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace eUniversity.Application.Functions.Semesters.Queries.GetSemestersList
{
    public class GetSemestersListQueryHandler : IRequestHandler<GetSemestersListQuery, SemestersListDto>
    {
        private readonly ISemesterRepository _semesterRepository;
        private readonly IMapper _mapper;

        public GetSemestersListQueryHandler(ISemesterRepository semesterRepository, IMapper mapper)
        {
            _semesterRepository = semesterRepository;
            _mapper = mapper;
        }

        public async Task<SemestersListDto> Handle(GetSemestersListQuery request, CancellationToken cancellationToken)
        {
            var semesters = await _semesterRepository.GetAllAsync();
            return new SemestersListDto
            {
                Semesters = _mapper.Map<List<SemesterDto>>(semesters)
            };
        }
    }
}
