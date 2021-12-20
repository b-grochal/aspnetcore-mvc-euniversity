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
