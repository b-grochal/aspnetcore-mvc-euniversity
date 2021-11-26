using eUniversity.Application.Contracts.Infrastructure.Services;
using eUniversity.Infrastructure.Entities;
using eUniversity.WebUI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace eUniversity.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IAuthService _authService;

        public HomeController(ILogger<HomeController> logger, UserManager<ApplicationUser> userManager, IAuthService authService)
        {
            _logger = logger;
            _userManager = userManager;
            _authService = authService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> PrivacyAsync()
        {
            var result = await _userManager.CreateAsync(new IdentityAdmin { FirstName = "Edward", UserName="Maciek" }, "P@ssw0rd");
            return View();
        }

        public async Task<IActionResult> LoginAsync()
        {
            var result = await _authService.Login("michsco123", "P@ssw0rd");
            return RedirectToAction(nameof(HomeController.Index), "Home");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
