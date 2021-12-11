using AutoMapper;
using eUniversity.Application.Contracts.Infrastructure.Repositories;
using eUniversity.Domain.Enitities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace eUniversity.Application.Functions.Students.Commands.UpdateStudent
{
    class UpdateStudentCommandHandler : IRequestHandler<UpdateStudentCommand>
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;

        public UpdateStudentCommandHandler(IStudentRepository studentRepository, IMapper mapper)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateStudentCommand request, CancellationToken cancellationToken)
        {
            var student = _mapper.Map<Student>(request);

            await _studentRepository.UpdateAsync(student);

            return Unit.Value;
        }
    }
}
