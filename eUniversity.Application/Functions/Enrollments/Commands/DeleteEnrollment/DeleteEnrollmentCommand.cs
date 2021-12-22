using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUniversity.Application.Functions.Enrollments.Commands.DeleteEnrollment
{
    public class DeleteEnrollmentCommand : IRequest
    {
        public int EnrollmentId { get; set; }
    }
}
