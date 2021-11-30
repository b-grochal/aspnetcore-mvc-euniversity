using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eUniversity.WebUI.Controllers
{
    public class AdminsController : Controller
    {

        public AdminsController()
        {

        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
