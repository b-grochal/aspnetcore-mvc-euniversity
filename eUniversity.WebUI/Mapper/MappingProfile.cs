using AutoMapper;
using eUniversity.Application.Functions.Auth.Commands.Login;
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
        }
    }
}
