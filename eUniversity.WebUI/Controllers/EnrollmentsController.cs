using AutoMapper;
using eUniversity.Application.Functions.Enrollments.Queries.GetEnrollmentsListForStudent;
using eUniversity.WebUI.Models.Enrollments;
using MediatR;
using Microsoft.AspNetCore.Mvc;
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
            var getEnrollmentDetailQuery = new GetAdminDetailQuery
            {
                Id = enrollmentId
            };

            var adminDetailsDto = await _mediator.Send(getEnrollmentDetailQuery);
            var editAdminViewModel = _mapper.Map<EditAdminViewModel>(adminDetailsDto);

            return View(editAdminViewModel);
        }

        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPost(int adminId, EditAdminViewModel editAdminViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(editAdminViewModel);
            }

            var updateAdminCommand = _mapper.Map<UpdateAdminCommand>(editAdminViewModel);
            await _mediator.Send(updateAdminCommand);

            return RedirectToAction(nameof(List));
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
    }
}
