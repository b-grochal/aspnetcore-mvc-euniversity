﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUniversity.Application.Functions.Enrollments.Commands.UpdateEnrollment
{
    public class UpdateEnrollmentCommand : IRequest
    {
        public int EnrollmentId { get; set; }
        public int GradeId { get; set; }
    }
}
