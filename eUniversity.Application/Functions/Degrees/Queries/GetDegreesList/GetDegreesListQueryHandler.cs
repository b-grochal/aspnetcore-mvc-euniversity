using AutoMapper;
using eUniversity.Application.Contracts.Infrastructure.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace eUniversity.Application.Functions.Degrees.Queries.GetDegreesList
{
    public class GetDegreesListQueryHandler : IRequestHandler<GetDegreesListQuery, DegreesListDto>
    {
        private readonly IDegreeRepository _degreeRepository;
        private readonly IMapper _mapper;

        public GetDegreesListQueryHandler(IDegreeRepository degreeRepository, IMapper mapper)
        {
            _degreeRepository = degreeRepository;
            _mapper = mapper;
        }

        public async Task<DegreesListDto> Handle(GetDegreesListQuery request, CancellationToken cancellationToken)
        {
            var degrees = await _degreeRepository.GetAllAsync();
            return new DegreesListDto
            {
                Degrees = _mapper.Map<List<DegreeDto>>(degrees)
            };
        }
    }
}
