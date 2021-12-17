using AutoMapper;
using eUniversity.Application.Functions.Courses.Commands.CreateCourse;
using eUniversity.Application.Functions.Courses.Commands.DeleteCourse;
using eUniversity.Application.Functions.Courses.Commands.UpdateCourse;
using eUniversity.Application.Functions.Courses.Queries.GetCourseDetails;
using eUniversity.Application.Functions.Courses.Queries.GetCoursesList;
using eUniversity.WebUI.Models.Courses;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<IActionResult> Delete(int studentId)
        {
            var getCourseDetailsQuery = new GetCourseDetailsQuery
            {
                Id = studentId
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
    }
}
