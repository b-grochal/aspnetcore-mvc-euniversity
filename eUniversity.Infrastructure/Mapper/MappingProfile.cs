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
            CreateMap<Admin, ApplicationUser>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.AdminId));

            CreateMap<Student, ApplicationUser>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.StudentId));

            CreateMap<Teacher, ApplicationUser>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.TeacherId));
        }
    }
}
