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

namespace eUniversity.Application.Functions.Teachers.Commands.UpdateTeacher
{
    public class UpdateTeacherCommandHandler : IRequestHandler<UpdateTeacherCommand>
    {
        private readonly ITeacherRepository _teacherRepository;
        private readonly IMapper _mapper;

        public UpdateTeacherCommandHandler(ITeacherRepository teacherRepository, IMapper mapper)
        {
            _teacherRepository = teacherRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateTeacherCommand request, CancellationToken cancellationToken)
        {
            var teacher = _mapper.Map<Teacher>(request);

            await _teacherRepository.UpdateAsync(teacher);

            return Unit.Value;
        }
    }
}
