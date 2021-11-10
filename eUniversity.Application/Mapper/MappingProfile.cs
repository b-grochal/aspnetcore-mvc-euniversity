using AutoMapper;
using eUniversity.Application.Functions.Admins.Commands.CreateAdmin;
using eUniversity.Application.Functions.Admins.Commands.UpdateAdmin;
using eUniversity.Application.Functions.Admins.Queries.GetAdminDetail;
using eUniversity.Application.Functions.Admins.Queries.GetAdminsList;
using eUniversity.Domain.Enitities;
using System;
using System.Collections.Generic;
using System.Text;

namespace eUniversity.Application.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateAdminCommand, Admin>()
                .ReverseMap();

            CreateMap<UpdateAdminCommand, Admin>()
                .ReverseMap();

            CreateMap<Admin, AdminDetailViewModel>()
                .ReverseMap();

            CreateMap<Admin, AdminViewModel>()
                .ReverseMap();
        }
    }
}
