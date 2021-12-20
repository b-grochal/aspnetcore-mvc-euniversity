using AutoMapper;
using eUniversity.Application.Contracts.Infrastructure.Repositories;
using eUniversity.Domain.Enitities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace eUniversity.Application.Functions.Courses.Commands.EnrollOnCourse
{
    public class EnrollOnCourseCommandHandler : IRequestHandler<EnrollOnCourseCommand, EnrollOnCourseCommandResponse>
    {
        private readonly IEnrollmentRepository _enrollmentRepository;
        private readonly ICourseRepository _courseRepository;
        private readonly IGradeRepository _gradeRepository;
        private readonly IMapper _mapper;

        public EnrollOnCourseCommandHandler(IEnrollmentRepository enrollmentRepository, ICourseRepository courseRepository, IGradeRepository gradeRepository, IMapper mapper)
        {
            _enrollmentRepository = enrollmentRepository;
            _courseRepository = courseRepository;
            _gradeRepository = gradeRepository;
            _mapper = mapper;
        }

        public async Task<EnrollOnCourseCommandResponse> Handle(EnrollOnCourseCommand request, CancellationToken cancellationToken)
        {
            var course = await _courseRepository.GetByIdAsync(request.CourseId);

            if(!BCrypt.Net.BCrypt.Verify(request.Password, course.PasswordHash))
                return new EnrollOnCourseCommandResponse("Invalid password", false);

            var defaultGrade = await _gradeRepository.GetDefaultGrade();

            var enrollment = _mapper.Map<Enrollment>(request);
            enrollment.GradeId = defaultGrade.GradeId;

            enrollment = await _enrollmentRepository.AddAsync(enrollment);

            return new EnrollOnCourseCommandResponse(enrollment.EnrollmentId);
        }
    }
}
