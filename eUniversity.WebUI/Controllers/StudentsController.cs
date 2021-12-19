using AutoMapper;
using eUniversity.Application.Functions.Students.Commands.CreateStudent;
using eUniversity.Application.Functions.Students.Commands.DeleteStudent;
using eUniversity.Application.Functions.Students.Commands.UpdateStudent;
using eUniversity.Application.Functions.Students.Queries.GetStudentDetails;
using eUniversity.Application.Functions.Students.Queries.GetStudentsList;
using eUniversity.WebUI.Models.Students;
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
    public class StudentsController : Controller
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public StudentsController(IMediator mediator, IMapper mapper)
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
        public async Task<IActionResult> Create(CreateStudentViewModel createStudentViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(createStudentViewModel);
            }

            var createStudentCommand = _mapper.Map<CreateStudentCommand>(createStudentViewModel);
            var response = await _mediator.Send(createStudentCommand);

            if (!response.Success)
            {
                response.ValidationErrors.ForEach(x => ModelState.AddModelError(x, x));
                return View(createStudentViewModel);
            }

            return RedirectToAction(nameof(List));
        }

        public async Task<IActionResult> Details(int studentId)
        {
            var getStudentDetailsQuery = new GetStudentDetailsQuery
            {
                Id = studentId
            };

            var studentDetailsDto = await _mediator.Send(getStudentDetailsQuery);
            var studentDetailsViewModel = _mapper.Map<StudentDetailsViewModel>(studentDetailsDto);

            return View(studentDetailsViewModel);
        }

        public async Task<IActionResult> Edit(int studentId)
        {
            var getStudentDetailsQuery = new GetStudentDetailsQuery
            {
                Id = studentId
            };

            var studentDetailsDto = await _mediator.Send(getStudentDetailsQuery);
            var editStudentViewModel = _mapper.Map<EditStudentViewModel>(studentDetailsDto);

            return View(editStudentViewModel);
        }

        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPost(int studentId, EditStudentViewModel editStudentViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(editStudentViewModel);
            }

            var updateStudentCommand = _mapper.Map<UpdateStudentCommand>(editStudentViewModel);
            await _mediator.Send(updateStudentCommand);

            return RedirectToAction(nameof(List));
        }

        public async Task<IActionResult> Delete(int studentId)
        {
            var getStudentDetailsQuery = new GetStudentDetailsQuery
            {
                Id = studentId
            };

            var studentDetailsDto = await _mediator.Send(getStudentDetailsQuery);
            var studentViewModel = _mapper.Map<StudentViewModel>(studentDetailsDto);

            return View(studentViewModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int studentId)
        {
            var deleteStudentCommand = new DeleteStudentCommand
            {
                StudentId = studentId
            };

            await _mediator.Send(deleteStudentCommand);

            return RedirectToAction(nameof(List));
        }

        public async Task<IActionResult> List(string searchedUsername)
        {
            var getStudentsListQuery = new GetStudentsListQuery
            {
                SearchedUserName = searchedUsername
            };

            var studentsListDto = await _mediator.Send(getStudentsListQuery);
            var studentsListViewModel = _mapper.Map<StudentsListViewModel>(studentsListDto);

            return View(studentsListViewModel);
        }
    }
}
