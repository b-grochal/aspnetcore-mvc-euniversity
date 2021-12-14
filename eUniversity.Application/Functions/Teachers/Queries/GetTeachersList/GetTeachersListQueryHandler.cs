using AutoMapper;
using eUniversity.Application.Contracts.Infrastructure.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace eUniversity.Application.Functions.Teachers.Queries.GetTeachersList
{
    public class GetTeachersListQueryHandler : IRequestHandler<GetTeachersListQuery, TeachersListDto>
    {
        private readonly ITeacherRepository _teacherRepository;
        private readonly IMapper _mapper;

        public GetTeachersListQueryHandler(ITeacherRepository teacherRepository, IMapper mapper)
        {
            _teacherRepository = teacherRepository;
            _mapper = mapper;
        }

        public async Task<TeachersListDto> Handle(GetTeachersListQuery request, CancellationToken cancellationToken)
        {
            var teachers = await _teacherRepository.GetAllAsync(request.SearchedUserName);
            return new TeachersListDto
            {
                Teachers = _mapper.Map<List<TeacherDto>>(teachers),
                SearchedUsername = request.SearchedUserName
            };
        }
    }
}
