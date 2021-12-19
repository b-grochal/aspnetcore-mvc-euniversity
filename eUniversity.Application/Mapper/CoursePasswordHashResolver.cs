using AutoMapper;
using BCrypt.Net;
using eUniversity.Application.Functions.Courses.Commands.CreateCourse;
using eUniversity.Domain.Enitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUniversity.Application.Mapper
{
    class CoursePasswordHashResolver : IValueResolver<CreateCourseCommand, Course, string>
    {
        public string Resolve(CreateCourseCommand source, Course destination, string destMember, ResolutionContext context)
        {
            return BCrypt.Net.BCrypt.HashPassword(source.Password);
        }
    }
}
