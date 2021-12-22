using AutoMapper;
using eUniversity.Application.Contracts.Infrastructure.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace eUniversity.Application.Functions.Grades.Queries.GetGradesList
{
    public class GetGradesListQueryHandler : IRequestHandler<GetGradesListQuery, GradesListDto>
    {
        private readonly IGradeRepository _gradeRepository;
        private readonly IMapper _mapper;

        public GetGradesListQueryHandler(IGradeRepository gradeRepository, IMapper mapper)
        {
            _gradeRepository = gradeRepository;
            _mapper = mapper;
        }

        public async Task<GradesListDto> Handle(GetGradesListQuery request, CancellationToken cancellationToken)
        {
            var grades = await _gradeRepository.GetAllAsync();
            return new GradesListDto
            {
                Grades = _mapper.Map<List<GradeDto>>(grades)
            };
        }
    }
}
