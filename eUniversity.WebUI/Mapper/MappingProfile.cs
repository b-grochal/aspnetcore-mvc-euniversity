using AutoMapper;
using eUniversity.Application.Functions.Admins.Commands.CreateAdmin;
using eUniversity.Application.Functions.Admins.Commands.UpdateAdmin;
using eUniversity.Application.Functions.Admins.Queries.GetAdminDetail;
using eUniversity.Application.Functions.Admins.Queries.GetAdminsList;
using eUniversity.Application.Functions.Auth.Commands.Login;
using eUniversity.Application.Functions.Courses.Commands.CreateCourse;
using eUniversity.Application.Functions.Courses.Commands.EnrollOnCourse;
using eUniversity.Application.Functions.Courses.Commands.UpdateCourse;
using eUniversity.Application.Functions.Courses.Queries.GetCourseDetails;
using eUniversity.Application.Functions.Courses.Queries.GetCoursesList;
using eUniversity.Application.Functions.Courses.Queries.GetCoursesListForStudent;
using eUniversity.Application.Functions.Enrollments.Queries.GetEnrollmentsListForStudent;
using eUniversity.Application.Functions.Students.Commands.CreateStudent;
using eUniversity.Application.Functions.Students.Commands.UpdateStudent;
using eUniversity.Application.Functions.Students.Queries.GetStudentDetails;
using eUniversity.Application.Functions.Students.Queries.GetStudentsList;
using eUniversity.Application.Functions.Teachers.Commands.CreateTeacher;
using eUniversity.Application.Functions.Teachers.Commands.UpdateTeacher;
using eUniversity.Application.Functions.Teachers.Queries.GetTeacherDetails;
using eUniversity.Application.Functions.Teachers.Queries.GetTeachersList;
using eUniversity.WebUI.Models.Admins;
using eUniversity.WebUI.Models.Auth;
using eUniversity.WebUI.Models.Courses;
using eUniversity.WebUI.Models.Enrollments;
using eUniversity.WebUI.Models.Students;
using eUniversity.WebUI.Models.Teachers;
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
            CreateMap<AdminDto, AdminViewModel>();
            CreateMap<AdminsListDto, AdminsListViewModel>();

            CreateMap<CreateStudentViewModel, CreateStudentCommand>();
            CreateMap<StudentDetailsDto, StudentDetailsViewModel>();
            CreateMap<StudentDetailsDto, StudentViewModel>();
            CreateMap<StudentDetailsDto, EditStudentViewModel>();
            CreateMap<EditStudentViewModel, UpdateStudentCommand>();
            CreateMap<StudentDto, StudentViewModel>();
            CreateMap<StudentsListDto, StudentsListViewModel>();

            CreateMap<CreateTeacherViewModel, CreateTeacherCommand>();
            CreateMap<TeacherDetailsDto, TeacherDetailsViewModel>();
            CreateMap<TeacherDetailsDto, TeacherViewModel>();
            CreateMap<TeacherDetailsDto, EditTeacherViewModel>();
            CreateMap<EditTeacherViewModel, UpdateTeacherCommand>();
            CreateMap<TeacherDto, TeacherViewModel>();
            CreateMap<TeachersListDto, TeachersListViewModel>();

            CreateMap<CreateCourseViewModel, CreateCourseCommand>();
            CreateMap<CourseDetailsDto, CourseDetailsViewModel>();
            CreateMap<CourseDetailsDto, CourseViewModel>();
            CreateMap<CourseDetailsDto, EditCourseViewModel>();
            CreateMap<EditCourseViewModel, UpdateCourseCommand>();
            CreateMap<CourseDto, CourseViewModel>();
            CreateMap<CoursesListDto, CoursesListViewModel>();
            CreateMap<CourseForStudentDto, CourseForStudentViewModel>();
            CreateMap<CoursesListForStudentDto, CoursesListForStudentViewModel>();
            CreateMap<CourseDetailsDto, EnrollOnCourseViewModel>()
                .ForMember(dest => dest.CourseName, opt => opt.MapFrom(src => src.Name));
            CreateMap<EnrollOnCourseViewModel, EnrollOnCourseCommand>();

            CreateMap<EnrollmentDto, EnrollmentViewModel>();
            CreateMap<EnrollmentForStudentDto, EnrollmentForStudentViewModel>();
            CreateMap<EnrollmentsListForStudentDto, EnrollmentsListForStudentViewModel>();
        }
    }
}
