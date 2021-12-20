using AutoMapper;
using eUniversity.Application.Contracts.Infrastructure.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace eUniversity.Application.Functions.Enrollments.Queries.GetEnrollmentsListForStudent
{
    public class GetEnrollmentsListForStudentQueryHandler : IRequestHandler<GetEnrollmentsListForStudentQuery, EnrollmentsListForStudentDto>
    {
        private readonly IEnrollmentRepository _enrollmentRepository;
        private readonly IMapper _mapper;

        public GetEnrollmentsListForStudentQueryHandler(IEnrollmentRepository enrollmentRepository, IMapper mapper)
        {
            _enrollmentRepository = enrollmentRepository;
            _mapper = mapper;
        }

        public async Task<EnrollmentsListForStudentDto> Handle(GetEnrollmentsListForStudentQuery request, CancellationToken cancellationToken)
        {
            var enrollments = await _enrollmentRepository.GetAllAsync(request.StudentId);
            var orderedEnrollments = enrollments.OrderByDescending(e => e.Course.SemesterId).ToList();
            var enrollmentsDto = _mapper.Map<List<EnrollmentForStudentDto>>(orderedEnrollments);

            return new EnrollmentsListForStudentDto
            {
                Enrollments = enrollmentsDto
            };
        }
    }
}
