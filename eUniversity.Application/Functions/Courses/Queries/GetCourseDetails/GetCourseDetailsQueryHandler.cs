using AutoMapper;
using eUniversity.Application.Contracts.Infrastructure.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace eUniversity.Application.Functions.Courses.Queries.GetCourseDetails
{
    public class GetCourseDetailsQueryHandler : IRequestHandler<GetCourseDetailsQuery, CourseDetailsDto>
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IMapper _mapper;

        public GetCourseDetailsQueryHandler(ICourseRepository courseRepository, IMapper mapper)
        {
            _courseRepository = courseRepository;
            _mapper = mapper;
        }

        public async Task<CourseDetailsDto> Handle(GetCourseDetailsQuery request, CancellationToken cancellationToken)
        {
            var course = await _courseRepository.GetByIdAsync(request.Id);

            var courseDetail = _mapper.Map<CourseDetailsDto>(course);

            return courseDetail;
        }
    }
}
