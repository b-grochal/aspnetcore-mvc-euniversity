using AutoMapper;
using eUniversity.Application.Contracts.Infrastructure.Repositories;
using eUniversity.Application.Functions.Admins.Commands.CreateAdmin;
using eUniversity.Domain.Enitities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace eUniversity.Application.Functions.Students.Commands.CreateStudent
{
    class CreateStudentCommandHandler : IRequestHandler<CreateStudentCommand, CreateStudentCommandResponse>
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;

        public CreateStudentCommandHandler(IStudentRepository studentRepository, IMapper mapper)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
        }

        public async Task<CreateStudentCommandResponse> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateStudentCommandValidator();
            var validatorResult = await validator.ValidateAsync(request);

            if (!validatorResult.IsValid)
                return new CreateStudentCommandResponse(validatorResult);

            var student = _mapper.Map<Student>(request);
            student = await _studentRepository.AddAsync(student, request.Password);

            return new CreateStudentCommandResponse(student.StudentId);
        }
    }
}