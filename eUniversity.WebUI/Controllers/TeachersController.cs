using AutoMapper;
using eUniversity.Application.Functions.Teachers.Commands.CreateTeacher;
using eUniversity.Application.Functions.Teachers.Commands.DeleteTeacher;
using eUniversity.Application.Functions.Teachers.Commands.UpdateTeacher;
using eUniversity.Application.Functions.Teachers.Queries.GetTeacherDetails;
using eUniversity.Application.Functions.Teachers.Queries.GetTeachersList;
using eUniversity.WebUI.Models.Teachers;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eUniversity.WebUI.Controllers
{
    [Authorize(Policy = "isAdmin")]
    public class TeachersController : Controller
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public TeachersController(IMediator mediator, IMapper mapper)
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
        public async Task<IActionResult> Create(CreateTeacherViewModel createTeacherViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(createTeacherViewModel);
            }

            var createTeacherCommand = _mapper.Map<CreateTeacherCommand>(createTeacherViewModel);
            var response = await _mediator.Send(createTeacherCommand);

            if (!response.Success)
            {
                response.ValidationErrors.ForEach(x => ModelState.AddModelError(x, x));
                return View(createTeacherViewModel);
            }

            return RedirectToAction(nameof(List));
        }

        public async Task<IActionResult> Details(int teacherId)
        {
            var getTeacherDetailsQuery = new GetTeacherDetailsQuery
            {
                Id = teacherId
            };

            var teacherDetailsDto = await _mediator.Send(getTeacherDetailsQuery);
            var teacherDetailsViewModel = _mapper.Map<TeacherDetailsViewModel>(teacherDetailsDto);

            return View(teacherDetailsViewModel);
        }

        public async Task<IActionResult> Edit(int teacherId)
        {
            var getTeacherDetailsQuery = new GetTeacherDetailsQuery
            {
                Id = teacherId
            };

            var teacherDetailsDto = await _mediator.Send(getTeacherDetailsQuery);
            var editTeacherViewModel = _mapper.Map<EditTeacherViewModel>(teacherDetailsDto);

            return View(editTeacherViewModel);
        }

        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPost(int teacherId, EditTeacherViewModel editTeacherViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(editTeacherViewModel);
            }

            var updateTeacherCommand = _mapper.Map<UpdateTeacherCommand>(editTeacherViewModel);
            await _mediator.Send(updateTeacherCommand);

            return RedirectToAction(nameof(List));
        }

        public async Task<IActionResult> Delete(int teacherId)
        {
            var getTeacherDetailQuery = new GetTeacherDetailsQuery
            {
                Id = teacherId
            };

            var teacherDetailsDto = await _mediator.Send(getTeacherDetailQuery);
            var teacherViewModel = _mapper.Map<TeacherViewModel>(teacherDetailsDto);

            return View(teacherViewModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int teacherId)
        {
            var deleteTeacherCommand = new DeleteTeacherCommand
            {
                TeacherId = teacherId
            };

            await _mediator.Send(deleteTeacherCommand);

            return RedirectToAction(nameof(List));
        }

        public async Task<IActionResult> List(string searchedUsername)
        {
            var getTeachersListQuery = new GetTeachersListQuery
            {
                SearchedUserName = searchedUsername
            };

            var teachersListDto = await _mediator.Send(getTeachersListQuery);
            var teachersListViewModel = _mapper.Map<TeachersListViewModel>(teachersListDto);

            return View(teachersListViewModel);
        }
    }
}
