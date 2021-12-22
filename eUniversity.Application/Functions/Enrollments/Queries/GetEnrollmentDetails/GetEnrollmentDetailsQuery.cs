using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUniversity.Application.Functions.Enrollments.Queries.GetEnrollmentDetails
{
    public class GetEnrollmentDetailsQuery : IRequest<EnrollmentDetailsDto>
    {
        public int Id { get; set; }
    }
}
