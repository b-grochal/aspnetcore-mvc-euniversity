using AutoMapper;
using eUniversity.Application.Functions.Courses.Queries.GetCourseDetails;
using eUniversity.Domain.Enitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUniversity.Application.Mapper
{
    public class StudentFullNameResolver : IValueResolver<Enrollment, EnrollmentDto, string>
    {
        public string Resolve(Enrollment source, EnrollmentDto destination, string destMember, ResolutionContext context)
        {
            return $"{source.Student.FirstName}  {source.Student.LastName}";
        }
    }
}
