using AutoMapper;
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
            return View();
        }

        public async Task<IActionResult> Details(int? id)
        {
            return View();
        }

        public async Task<IActionResult> Edit(int? id)
        {
            return View();
        }

        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPost(int? id, EditAdminViewModel editAdminViewModel)
        {
            return View();
        }

        public async Task<IActionResult> Delete(int? id)
        {
            return View();
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            return View();
        }

        public IActionResult List(string searchedUsername)
        {
            return View();
        }
    }
}
