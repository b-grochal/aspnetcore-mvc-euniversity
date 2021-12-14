using AutoMapper;
using eUniversity.Application.Contracts.Infrastructure.Repositories;
using eUniversity.Application.Functions.Students.Queries.GetStudentDetails;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace eUniversity.Application.Functions.Teachers.Queries.GetTeacherDetails
{
    public class GetTeacherDetailsQueryHandler : IRequestHandler<GetTeacherDetailsQuery, TeacherDetailsDto>
    {
        private readonly ITeacherRepository _teacherRepository;
        private readonly IMapper _mapper;

        public GetTeacherDetailsQueryHandler(ITeacherRepository teacherRepository, IMapper mapper)
        {
            _teacherRepository = teacherRepository;
            _mapper = mapper;
        }

        public async Task<TeacherDetailsDto> Handle(GetTeacherDetailsQuery request, CancellationToken cancellationToken)
        {
            var teacher = await _teacherRepository.GetByIdAsync(request.Id);

            var teacherDetails = _mapper.Map<TeacherDetailsDto>(teacher);

            return teacherDetails;
        }
    }
}
