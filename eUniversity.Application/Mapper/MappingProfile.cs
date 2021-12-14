using AutoMapper;
using eUniversity.Application.Functions.Admins.Commands.CreateAdmin;
using eUniversity.Application.Functions.Admins.Commands.UpdateAdmin;
using eUniversity.Application.Functions.Admins.Queries.GetAdminDetail;
using eUniversity.Application.Functions.Admins.Queries.GetAdminsList;
using eUniversity.Application.Functions.Students.Commands.CreateStudent;
using eUniversity.Application.Functions.Students.Commands.UpdateStudent;
using eUniversity.Application.Functions.Students.Queries.GetStudentDetails;
using eUniversity.Application.Functions.Students.Queries.GetStudentsList;
using eUniversity.Application.Functions.Teachers.Commands.CreateTeacher;
using eUniversity.Application.Functions.Teachers.Commands.UpdateTeacher;
using eUniversity.Application.Functions.Teachers.Queries.GetTeacherDetails;
using eUniversity.Application.Functions.Teachers.Queries.GetTeachersList;
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
            // Admins
            CreateMap<CreateAdminCommand, Admin>()
                .ReverseMap();

            CreateMap<UpdateAdminCommand, Admin>()
                .ReverseMap();

            CreateMap<Admin, AdminDetailsDto>()
                .ReverseMap();

            CreateMap<Admin, AdminDto>()
                .ReverseMap();

            // Students
            CreateMap<CreateStudentCommand, Student>()
                .ReverseMap();

            CreateMap<UpdateStudentCommand, Student>()
                .ReverseMap();

            CreateMap<Student, StudentDetailsDto>()
                .ReverseMap();

            CreateMap<Student, StudentDto>()
                .ReverseMap();

            // Teachers
            CreateMap<CreateTeacherCommand, Teacher>()
                .ReverseMap();

            CreateMap<UpdateTeacherCommand, Teacher>()
                .ReverseMap();

            CreateMap<Teacher, TeacherDetailsDto>()
                .ReverseMap();

            CreateMap<Teacher, TeacherDto>()
                .ReverseMap();
        }
    }
}
