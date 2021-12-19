using AutoMapper;
using eUniversity.Application.Contracts.Infrastructure.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace eUniversity.Application.Functions.Students.Queries.GetStudentsList
{
    public class GetStudentsListQueryHandler : IRequestHandler<GetStudentsListQuery, StudentsListDto>
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;

        public GetStudentsListQueryHandler(IStudentRepository studentRepository, IMapper mapper)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
        }

        public async Task<StudentsListDto> Handle(GetStudentsListQuery request, CancellationToken cancellationToken)
        {
            var students = await _studentRepository.GetAllAsync(request.SearchedUserName);
            return new StudentsListDto
            {
                Students = _mapper.Map<List<StudentDto>>(students),
                SearchedUsername = request.SearchedUserName
            };
        }
    }
}
