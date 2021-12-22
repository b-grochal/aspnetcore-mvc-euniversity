using AutoMapper;
using eUniversity.Application.Contracts.Infrastructure.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace eUniversity.Application.Functions.Enrollments.Queries.GetEnrollmentDetails
{
    public class GetEnrollmentDetailsQueryHandler : IRequestHandler<GetEnrollmentDetailsQuery, EnrollmentDetailsDto>
    {
        private readonly IEnrollmentRepository _enrollmentRepository;
        private readonly IMapper _mapper;

        public GetEnrollmentDetailsQueryHandler(IEnrollmentRepository enrollmentRepository, IMapper mapper)
        {
            _enrollmentRepository = enrollmentRepository;
            _mapper = mapper;
        }

        public async Task<EnrollmentDetailsDto> Handle(GetEnrollmentDetailsQuery request, CancellationToken cancellationToken)
        {
            var enrollment = await _enrollmentRepository.GetByIdAsync(request.Id);

            var enrollmentDetails = _mapper.Map<EnrollmentDetailsDto>(enrollment);

            return enrollmentDetails;
        }
    }
}
