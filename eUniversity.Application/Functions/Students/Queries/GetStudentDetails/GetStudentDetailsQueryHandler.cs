using AutoMapper;
using eUniversity.Application.Contracts.Infrastructure.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace eUniversity.Application.Functions.Students.Queries.GetStudentDetails
{
    public class GetStudentDetailsQueryHandler : IRequestHandler<GetStudentDetailsQuery, StudentDetailsDto>
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;

        public GetStudentDetailsQueryHandler(IStudentRepository studentRepository, IMapper mapper)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
        }

        public async Task<StudentDetailsDto> Handle(GetStudentDetailsQuery request, CancellationToken cancellationToken)
        {
            var student = await _studentRepository.GetByIdAsync(request.Id);

            var studentDetails = _mapper.Map<StudentDetailsDto>(student);

            return studentDetails;
        }
    }
}
