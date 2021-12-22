using AutoMapper;
using eUniversity.Application.Contracts.Infrastructure.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace eUniversity.Application.Functions.Enrollments.Commands.UpdateEnrollment
{
    public class UpdateEnrollmentCommandHandler : IRequestHandler<UpdateEnrollmentCommand>
    {
        private readonly IEnrollmentRepository _enrollmentRepository;
        private readonly IMapper _mapper;

        public UpdateEnrollmentCommandHandler(IEnrollmentRepository enrollmentRepository, IMapper mapper)
        {
            _enrollmentRepository = enrollmentRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateEnrollmentCommand request, CancellationToken cancellationToken)
        {
            var enrollmentToUpdate = await _enrollmentRepository.GetByIdAsync(request.EnrollmentId);
            var updatedEnrollment = _mapper.Map(request, enrollmentToUpdate);

            await _enrollmentRepository.UpdateAsync(updatedEnrollment);

            return Unit.Value;
        }
    }
}
