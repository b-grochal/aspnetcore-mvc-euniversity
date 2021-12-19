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

namespace eUniversity.Application.Functions.Teachers.Commands.CreateTeacher
{
    class CreateTeacherCommandHandler : IRequestHandler<CreateTeacherCommand, CreateTeacherCommandResponse>
    {
        private readonly ITeacherRepository _teacherRepository;
        private readonly IMapper _mapper;

        public CreateTeacherCommandHandler(ITeacherRepository teacherRepository, IMapper mapper)
        {
            _teacherRepository = teacherRepository;
            _mapper = mapper;
        }
        public async Task<CreateTeacherCommandResponse> Handle(CreateTeacherCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateTeacherCommandValidator();
            var validatorResult = await validator.ValidateAsync(request);

            if (!validatorResult.IsValid)
                return new CreateTeacherCommandResponse(validatorResult);

            var teacher = _mapper.Map<Teacher>(request);
            teacher = await _teacherRepository.AddAsync(teacher, request.Password);

            return new CreateTeacherCommandResponse(teacher.TeacherId);
        }
    }
}
