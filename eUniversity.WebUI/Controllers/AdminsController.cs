using AutoMapper;
using eUniversity.Application.Functions.Admins.Commands.CreateAdmin;
using eUniversity.Application.Functions.Admins.Commands.DeleteAdmin;
using eUniversity.Application.Functions.Admins.Commands.UpdateAdmin;
using eUniversity.Application.Functions.Admins.Queries.GetAdminDetail;
using eUniversity.Application.Functions.Admins.Queries.GetAdminsList;
using eUniversity.WebUI.Models.Admins;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eUniversity.WebUI.Controllers
{
    public class AdminsController : Controller
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public AdminsController(IMediator mediator, IMapper mapper)
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
        public async Task<IActionResult> Create(CreateAdminViewModel createAdminViewModel)
        {
            if(!ModelState.IsValid)
            {
                return View(createAdminViewModel);
            }

            var createAdminCommand = _mapper.Map<CreateAdminCommand>(createAdminViewModel);
            var response = await _mediator.Send(createAdminCommand);
            
            if (!response.Success)
            {
                response.ValidationErrors.ForEach(x => ModelState.AddModelError(x, x));
                return View(createAdminViewModel);
            }

            return RedirectToAction(nameof(List));
        }

        public async Task<IActionResult> Details(int id)
        {
            var getAdminDetailQuery = new GetAdminDetailQuery
            {
                Id = id
            };

            var adminDetailsDto = await _mediator.Send(getAdminDetailQuery);
            var adminDetailsViewModel = _mapper.Map<AdminDetailsViewModel>(adminDetailsDto);

            return View(adminDetailsViewModel);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var getAdminDetailQuery = new GetAdminDetailQuery
            {
                Id = id
            };

            var adminDetailsDto = await _mediator.Send(getAdminDetailQuery);
            var editAdminViewModel = _mapper.Map<EditAdminViewModel>(adminDetailsDto);

            return View(editAdminViewModel);
        }

        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPost(int id, EditAdminViewModel editAdminViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(editAdminViewModel);
            }

            var updateAdminCommand = _mapper.Map<UpdateAdminCommand>(editAdminViewModel);
            await _mediator.Send(updateAdminCommand);

            return RedirectToAction(nameof(List));
        }

        public async Task<IActionResult> Delete(int id)
        {
            var getAdminDetailQuery = new GetAdminDetailQuery
            {
                Id = id
            };

            var adminDetailsDto = await _mediator.Send(getAdminDetailQuery);
            var adminViewModel = _mapper.Map<AdminViewModel>(adminDetailsDto);

            return View(adminViewModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var deleteAdminCommand = new DeleteAdminCommand
            {
                AdminId = id
            };

            await _mediator.Send(deleteAdminCommand);

            return RedirectToAction(nameof(List));
        }

        public async Task<IActionResult> List(string searchedUsername)
        {
            var getAdminsListQuery = new GetAdminsListQuery
            {
                SearchedUserName = searchedUsername
            };

            var adminsListDto = await _mediator.Send(getAdminsListQuery);
            var adminsListViewModel = _mapper.Map<AdminsListViewModel>(adminsListDto);

            return View(adminsListViewModel);
        }
    }
}
