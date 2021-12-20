using AutoMapper;
using eUniversity.Application.Contracts.Infrastructure.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace eUniversity.Application.Functions.Courses.Queries.GetCoursesListForStudent
{
    public class GetCoursesListForStudentQueryHandler : IRequestHandler<GetCoursesListForStudentQuery, CoursesListForStudentDto>
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IEnrollmentRepository _enrollmentRepository;
        private readonly IMapper _mapper;

        public GetCoursesListForStudentQueryHandler(ICourseRepository courseRepository, IEnrollmentRepository enrollmentRepository, IMapper mapper)
        {
            _courseRepository = courseRepository;
            _enrollmentRepository = enrollmentRepository;
            _mapper = mapper;
        }

        public async Task<CoursesListForStudentDto> Handle(GetCoursesListForStudentQuery request, CancellationToken cancellationToken)
        {
            var courses = await _courseRepository.GetAllAsync(request.SearchedName);
            var studentsEnrollments = await _enrollmentRepository.GetAllAsync(request.StudentId);

            var coursesDto = _mapper.Map<List<CourseForStudentDto>>(courses);

            foreach(var course in coursesDto)
            {
                if(studentsEnrollments.Any(e => e.CourseId == course.CourseId))
                {
                    course.IsEnrolled = true;
                }
            }


            return new CoursesListForStudentDto
            {
                Courses = coursesDto,
                SearchedName = request.SearchedName
            };
        }
    }
}
