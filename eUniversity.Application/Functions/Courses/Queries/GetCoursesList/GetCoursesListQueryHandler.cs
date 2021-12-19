using AutoMapper;
using eUniversity.Application.Contracts.Infrastructure.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace eUniversity.Application.Functions.Courses.Queries.GetCoursesList
{
    public class GetCoursesListQueryHandler : IRequestHandler<GetCoursesListQuery, CoursesListDto>
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IMapper _mapper;

        public GetCoursesListQueryHandler(ICourseRepository courseRepository, IMapper mapper)
        {
            _courseRepository = courseRepository;
            _mapper = mapper;
        }

        public async Task<CoursesListDto> Handle(GetCoursesListQuery request, CancellationToken cancellationToken)
        {
            var courses = await _courseRepository.GetAllAsync(request.SearchedName);
            return new CoursesListDto
            {
                Courses = _mapper.Map<List<CourseDto>>(courses),
                SearchedName = request.SearchedName
            };
        }
    }
}
