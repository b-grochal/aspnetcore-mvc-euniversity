using AutoMapper;
using eUniversity.Application.Functions.Auth.Commands.Login;
using eUniversity.WebUI.Models.Auth;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eUniversity.WebUI.Controllers
{
    public class AuthController : Controller
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public AuthController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LoginAsync(LoginViewModel loginViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(loginViewModel);
            }

            var loginCommand = _mapper.Map<LoginCommand>(loginViewModel);
            var response = await _mediator.Send(loginCommand);

            if(!response.Success)
            {
                ModelState.AddModelError(response.Message, response.Message);
                response.ValidationErrors.ForEach(x => ModelState.AddModelError(x, x));
                return View(loginViewModel);
            }

            return RedirectToAction("Index", "Home");
        }
    }
}
