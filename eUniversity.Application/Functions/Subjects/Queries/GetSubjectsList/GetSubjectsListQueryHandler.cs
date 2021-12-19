using AutoMapper;
using eUniversity.Application.Contracts.Infrastructure.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace eUniversity.Application.Functions.Subjects.Queries.GetSubjectsList
{
    public class GetSubjectsListQueryHandler : IRequestHandler<GetSubjectsListQuery, SubjectsListDto>
    {
        private readonly ISubjectRepository _subjectRepository;
        private readonly IMapper _mapper;

        public GetSubjectsListQueryHandler(ISubjectRepository subjectRepository, IMapper mapper)
        {
            _subjectRepository = subjectRepository;
            _mapper = mapper;
        }

        public async Task<SubjectsListDto> Handle(GetSubjectsListQuery request, CancellationToken cancellationToken)
        {
            var subjects = await _subjectRepository.GetAllAsync();
            return new SubjectsListDto
            {
                Subjects = _mapper.Map<List<SubjectDto>>(subjects)
            };
        }
    }
}
