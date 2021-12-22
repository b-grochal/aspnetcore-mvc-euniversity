using eUniversity.Application.Contracts.Infrastructure.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace eUniversity.Application.Functions.Enrollments.Commands.DeleteEnrollment
{
    public class DeleteEnrollmentCommandHandler : IRequestHandler<DeleteEnrollmentCommand>
    {
        private readonly IEnrollmentRepository _enrollmentRepository;

        public DeleteEnrollmentCommandHandler(IEnrollmentRepository enrollmentRepository)
        {
            _enrollmentRepository = enrollmentRepository;
        }

        public async Task<Unit> Handle(DeleteEnrollmentCommand request, CancellationToken cancellationToken)
        {
            var enrollmentToDelete = await _enrollmentRepository.GetByIdAsync(request.EnrollmentId);

            await _enrollmentRepository.DeleteAsync(enrollmentToDelete);

            return Unit.Value;
        }
    }
}
