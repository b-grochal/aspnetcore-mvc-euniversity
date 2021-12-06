using AutoMapper;
using eUniversity.Application.Functions.Admins.Commands.CreateAdmin;
using eUniversity.Application.Functions.Admins.Commands.UpdateAdmin;
using eUniversity.Application.Functions.Admins.Queries.GetAdminDetail;
using eUniversity.Application.Functions.Admins.Queries.GetAdminsList;
using eUniversity.Application.Functions.Auth.Commands.Login;
using eUniversity.WebUI.Models.Admins;
using eUniversity.WebUI.Models.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eUniversity.WebUI.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<LoginViewModel, LoginCommand>();
            CreateMap<CreateAdminViewModel, CreateAdminCommand>();
            CreateMap<AdminDetailsDto, AdminDetailsViewModel>();
            CreateMap<AdminDetailsDto, AdminViewModel>();
            CreateMap<AdminDetailsDto, EditAdminViewModel>();
            CreateMap<EditAdminViewModel, UpdateAdminCommand>();


            CreateMap<AdminDto, AdminViewModel>()
                .ReverseMap();
            CreateMap<AdminsListDto, AdminsListViewModel>()
                .ReverseMap();
        }
    }
}
