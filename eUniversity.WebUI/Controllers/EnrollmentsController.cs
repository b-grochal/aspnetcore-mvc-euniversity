using AutoMapper;
using eUniversity.Application.Functions.Enrollments.Commands.DeleteEnrollment;
using eUniversity.Application.Functions.Enrollments.Commands.UpdateEnrollment;
using eUniversity.Application.Functions.Enrollments.Queries.GetEnrollmentDetails;
using eUniversity.Application.Functions.Enrollments.Queries.GetEnrollmentsListForStudent;
using eUniversity.Application.Functions.Grades.Queries.GetGradesList;
using eUniversity.WebUI.Models.Enrollments;
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
    public class EnrollmentsController : Controller
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public EnrollmentsController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        public async Task<IActionResult> Edit(int enrollmentId)
        {
            var getEnrollmentDetailsQuery = new GetEnrollmentDetailsQuery
            {
                Id = enrollmentId
            };

            var enrollmentDetailsDto = await _mediator.Send(getEnrollmentDetailsQuery);
            var editEnrollmentViewModel = _mapper.Map<EditEnrollmentViewModel>(enrollmentDetailsDto);

            await PopulateEditFormSelectElements();

            return View(editEnrollmentViewModel);
        }

        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditEnrollment(int enrollmentId, EditEnrollmentViewModel editEnrollmentViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(editEnrollmentViewModel);
            }

            var updateEnrollmentCommand = _mapper.Map<UpdateEnrollmentCommand>(editEnrollmentViewModel);
            await _mediator.Send(updateEnrollmentCommand);

            return RedirectToAction("List", "Courses");
        }

        public async Task<IActionResult> Delete(int enrollment)
        {
            var getEnrollmentDetailsQuery = new GetEnrollmentDetailsQuery
            {
                Id = enrollment
            };

            var enrollmentDetailsDto = await _mediator.Send(getEnrollmentDetailsQuery);
            var enrollmentDetailsViewModel = _mapper.Map<EnrollmentDetailsViewModel>(enrollmentDetailsDto);

            return View(enrollmentDetailsViewModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int enrollmentId)
        {
            var deleteEnrollmentCommand = new DeleteEnrollmentCommand
            {
                EnrollmentId = enrollmentId
            };

            await _mediator.Send(deleteEnrollmentCommand);

            return RedirectToAction("List", "Courses");
        }

        public async Task<IActionResult> ListForStudent()
        {
            var getEnrollmentsListForStudentQuery = new GetEnrollmentsListForStudentQuery
            {
                StudentId = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier))
            };

            var enrollmentsListForStudenDto = await _mediator.Send(getEnrollmentsListForStudentQuery);
            var enrollmentsListViewModel = _mapper.Map<EnrollmentsListForStudentViewModel>(enrollmentsListForStudenDto);

            return View(enrollmentsListViewModel);
        }

        private async Task PopulateEditFormSelectElements()
        {
            var getGradesListQuery = new GetGradesListQuery();

            var grades = await _mediator.Send(getGradesListQuery);

            ViewData["Grades"] = new SelectList(grades.Grades, "GradeId", "Name");
        }
    }
}
