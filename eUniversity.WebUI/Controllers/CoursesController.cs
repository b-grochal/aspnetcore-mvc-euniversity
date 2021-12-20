using AutoMapper;
using eUniversity.Application.Functions.Courses.Commands.CreateCourse;
using eUniversity.Application.Functions.Courses.Commands.DeleteCourse;
using eUniversity.Application.Functions.Courses.Commands.EnrollOnCourse;
using eUniversity.Application.Functions.Courses.Commands.UpdateCourse;
using eUniversity.Application.Functions.Courses.Queries.GetCourseDetails;
using eUniversity.Application.Functions.Courses.Queries.GetCoursesList;
using eUniversity.Application.Functions.Courses.Queries.GetCoursesListForStudent;
using eUniversity.Application.Functions.Degrees.Queries.GetDegreesList;
using eUniversity.Application.Functions.Semesters.Queries.GetSemestersList;
using eUniversity.Application.Functions.Subjects.Queries.GetSubjectsList;
using eUniversity.WebUI.Models.Courses;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace eUniversity.WebUI.Controllers
{
    public class CoursesController : Controller
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public CoursesController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        public async Task<IActionResult> Create()
        {
            await PopulateCreateFormSelectElements();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateCourseViewModel createCourseViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(createCourseViewModel);
            }

            var createCourseCommand = _mapper.Map<CreateCourseCommand>(createCourseViewModel);
            var response = await _mediator.Send(createCourseCommand);

            if (!response.Success)
            {
                response.ValidationErrors.ForEach(x => ModelState.AddModelError(x, x));
                return View(createCourseViewModel);
            }

            return RedirectToAction(nameof(List));
        }

        public async Task<IActionResult> Details(int courseId)
        {
            var getCourseDetailsQuery = new GetCourseDetailsQuery
            {
                Id = courseId
            };

            var courseDetailsDto = await _mediator.Send(getCourseDetailsQuery);
            var courseDetailsViewModel = _mapper.Map<CourseDetailsViewModel>(courseDetailsDto);

            return View(courseDetailsViewModel);
        }

        public async Task<IActionResult> Edit(int courseId)
        {
            var getCourseDetailsQuery = new GetCourseDetailsQuery
            {
                Id = courseId
            };

            var courseDetailsDto = await _mediator.Send(getCourseDetailsQuery);
            var editCourseViewModel = _mapper.Map<EditCourseViewModel>(courseDetailsDto);

            await PopulateEditFormSelectElements(editCourseViewModel.DegreeId, editCourseViewModel.SemesterId, editCourseViewModel.SubjectId);

            return View(editCourseViewModel);
        }

        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPost(int courseId, EditCourseViewModel editCourseViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(editCourseViewModel);
            }

            var updateCourseCommand = _mapper.Map<UpdateCourseCommand>(editCourseViewModel);
            await _mediator.Send(updateCourseCommand);

            return RedirectToAction(nameof(List));
        }

        public async Task<IActionResult> Delete(int courseId)
        {
            var getCourseDetailsQuery = new GetCourseDetailsQuery
            {
                Id = courseId
            };

            var courseDetailsDto = await _mediator.Send(getCourseDetailsQuery);
            var courseViewModel = _mapper.Map<CourseViewModel>(courseDetailsDto);

            return View(courseViewModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int courseId)
        {
            var deleteCourseCommand = new DeleteCourseCommand
            {
                CourseId = courseId
            };

            await _mediator.Send(deleteCourseCommand);

            return RedirectToAction(nameof(List));
        }

        public async Task<IActionResult> List(string searchedName)
        {
            var getCoursesListQuery = new GetCoursesListQuery
            {
                SearchedName = searchedName
            };

            var coursesListDto = await _mediator.Send(getCoursesListQuery);
            var coursesListViewModel = _mapper.Map<CoursesListViewModel>(coursesListDto);

            return View(coursesListViewModel);
        }

        public async Task<IActionResult> ListForStudent(string searchedName)
        {
            var getCoursesListForStudentQuery = new GetCoursesListForStudentQuery
            {
                SearchedName = searchedName,
                StudentId = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier))
            };

            var coursesListForStudenDto = await _mediator.Send(getCoursesListForStudentQuery);
            var coursesListViewModel = _mapper.Map<CoursesListForStudentViewModel>(coursesListForStudenDto);

            return View(coursesListViewModel);
        }

        public async Task<IActionResult> EnrollOnCourse(int courseId)
        {
            var getCourseDetailsQuery = new GetCourseDetailsQuery
            {
                Id = courseId
            };

            var courseDetailsDto = await _mediator.Send(getCourseDetailsQuery);
            var enrollOnCourseViewModel = _mapper.Map<EnrollOnCourseViewModel>(courseDetailsDto);

            return View(enrollOnCourseViewModel);
        }

        [HttpPost, ActionName("EnrollOnCourse")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EnrollOnCoursePost(int courseId, EnrollOnCourseViewModel enrollOnCourseViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(enrollOnCourseViewModel);
            }

            var enrollOnCourseCommand = _mapper.Map<EnrollOnCourseCommand>(enrollOnCourseViewModel);
            enrollOnCourseCommand.StudentId = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier));
            var response = await _mediator.Send(enrollOnCourseCommand);

            if (!response.Success)
            {
                ModelState.AddModelError(response.Message, response.Message);
                return View(enrollOnCourseViewModel);
            }

            return RedirectToAction(nameof(ListForStudent));
        }

        private async Task PopulateCreateFormSelectElements()
        {
            var getDegreesListQuery = new GetDegreesListQuery();
            var getSemestersListQuery = new GetSemestersListQuery();
            var getSubjectsListQuery = new GetSubjectsListQuery();
            
            var degrees = await _mediator.Send(getDegreesListQuery);
            var semesters = await _mediator.Send(getSemestersListQuery);
            var subjects = await _mediator.Send(getSubjectsListQuery);

            ViewData["Degrees"] = new SelectList(degrees.Degrees, "DegreeId", "Name");
            ViewData["Semesters"] = new SelectList(semesters.Semesters, "SemesterId", "Name");
            ViewData["Subjects"] = new SelectList(subjects.Subjects, "SubjectId", "Name");
        }

        private async Task PopulateEditFormSelectElements(int degreeId, int semesterId, int subjectId)
        {
            var getDegreesListQuery = new GetDegreesListQuery();
            var getSemestersListQuery = new GetSemestersListQuery();
            var getSubjectsListQuery = new GetSubjectsListQuery();

            var degrees = await _mediator.Send(getDegreesListQuery);
            var semesters = await _mediator.Send(getSemestersListQuery);
            var subjects = await _mediator.Send(getSubjectsListQuery);

            ViewData["Degrees"] = new SelectList(degrees.Degrees, "DegreeId", "Name", degreeId);
            ViewData["Semesters"] = new SelectList(semesters.Semesters, "SemesterId", "Name", semesterId);
            ViewData["Subjects"] = new SelectList(subjects.Subjects, "SubjectId", "Name", subjectId);
        }
    }
}
