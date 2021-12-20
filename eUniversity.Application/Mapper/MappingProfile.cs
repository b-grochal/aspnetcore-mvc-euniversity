using AutoMapper;
using eUniversity.Application.Functions.Admins.Commands.CreateAdmin;
using eUniversity.Application.Functions.Admins.Commands.UpdateAdmin;
using eUniversity.Application.Functions.Admins.Queries.GetAdminDetail;
using eUniversity.Application.Functions.Admins.Queries.GetAdminsList;
using eUniversity.Application.Functions.Courses.Commands.CreateCourse;
using eUniversity.Application.Functions.Courses.Commands.UpdateCourse;
using eUniversity.Application.Functions.Courses.Queries.GetCourseDetails;
using eUniversity.Application.Functions.Courses.Queries.GetCoursesList;
using eUniversity.Application.Functions.Courses.Queries.GetCoursesListForStudent;
using eUniversity.Application.Functions.Degrees.Queries.GetDegreesList;
using eUniversity.Application.Functions.Enrollments.Queries.GetEnrollmentsListForStudent;
using eUniversity.Application.Functions.Semesters.Queries.GetSemestersList;
using eUniversity.Application.Functions.Students.Commands.CreateStudent;
using eUniversity.Application.Functions.Students.Commands.UpdateStudent;
using eUniversity.Application.Functions.Students.Queries.GetStudentDetails;
using eUniversity.Application.Functions.Students.Queries.GetStudentsList;
using eUniversity.Application.Functions.Subjects.Queries.GetSubjectsList;
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
            CreateMap<CreateAdminCommand, Admin>();

            CreateMap<UpdateAdminCommand, Admin>();

            CreateMap<Admin, AdminDetailsDto>();

            CreateMap<Admin, AdminDto>();

            // Students
            CreateMap<CreateStudentCommand, Student>();

            CreateMap<UpdateStudentCommand, Student>();

            CreateMap<Student, StudentDetailsDto>();

            CreateMap<Student, StudentDto>();

            // Teachers
            CreateMap<CreateTeacherCommand, Teacher>();

            CreateMap<UpdateTeacherCommand, Teacher>();

            CreateMap<Teacher, TeacherDetailsDto>();

            CreateMap<Teacher, TeacherDto>();

            // Courses
            CreateMap<CreateCourseCommand, Course>()
                .ForMember(dest => dest.PasswordHash, opt => opt.MapFrom<CoursePasswordHashResolver>());

            CreateMap<UpdateCourseCommand, Course>();

            CreateMap<Enrollment, EnrollmentDto>()
                 .ForMember(dest => dest.StudentUsername, opt => opt.MapFrom(src => src.Student.UserName))
                 .ForMember(dest => dest.StudentFullName, opt => opt.MapFrom<StudentFullNameResolver>())
                 .ForMember(dest => dest.GradeName, opt => opt.MapFrom(src => src.Grade.Name));

            CreateMap<Course, CourseDetailsDto>()
                .ForMember(dest => dest.SubjectName, opt => opt.MapFrom(src => src.Subject.Name))
                .ForMember(dest => dest.DegreeName, opt => opt.MapFrom(src => src.Degree.Name))
                .ForMember(dest => dest.SemesterName, opt => opt.MapFrom(src => src.Semester.Name));

            CreateMap<Course, CourseDto>()
                .ForMember(dest => dest.SubjectName, opt => opt.MapFrom(src => src.Subject.Name))
                .ForMember(dest => dest.DegreeName, opt => opt.MapFrom(src => src.Degree.Name))
                .ForMember(dest => dest.SemesterName, opt => opt.MapFrom(src => src.Semester.Name));

            CreateMap<Course, CourseForStudentDto>()
                .ForMember(dest => dest.SubjectName, opt => opt.MapFrom(src => src.Subject.Name))
                .ForMember(dest => dest.DegreeName, opt => opt.MapFrom(src => src.Degree.Name))
                .ForMember(dest => dest.SemesterName, opt => opt.MapFrom(src => src.Semester.Name));

            // Degrees
            CreateMap<Degree, DegreeDto>();

            // Subjects
            CreateMap<Subject, SubjectDto>();

            // Semesters
            CreateMap<Semester, SemesterDto>();

            // Enrolments
            CreateMap<Enrollment, EnrollmentForStudentDto>()
                 .ForMember(dest => dest.CourseName, opt => opt.MapFrom(src => src.Course.Name))
                 .ForMember(dest => dest.SemesterName, opt => opt.MapFrom(src => src.Course.Semester.Name))
                 .ForMember(dest => dest.SubjectName, opt => opt.MapFrom(src => src.Course.Subject.Name))
                 .ForMember(dest => dest.DegreeName, opt => opt.MapFrom(src => src.Course.Degree.Name))
                 .ForMember(dest => dest.GradeName, opt => opt.MapFrom(src => src.Grade.Name));
        }
    }
}
