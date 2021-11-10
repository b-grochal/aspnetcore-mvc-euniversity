using AutoMapper;
using eUniversity.Domain.Enitities;
using eUniversity.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUniversity.Infrastructure.Mapper
{
    class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Admin, IdentityAdmin>()
                .ReverseMap();
        }
    }
}
