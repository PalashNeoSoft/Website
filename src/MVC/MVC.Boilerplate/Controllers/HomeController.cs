using Microsoft.AspNetCore.Mvc;
using MVC.Boilerplate.Common.Exceptions;
using MVC.Boilerplate.Models;
using System.Diagnostics;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using MVC.Boilerplate.Models.FileUpload;
using Microsoft.AspNetCore.Identity;
using MVC.Boilerplate.Models.Account;

namespace MVC.Boilerplate.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //private readonly UserManager<Login> _userManager;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            //_userManager = userManager;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("An example of logging");
            var session = HttpContext.Session.GetString("UserName");
            //var usr = _userManager.GetUserName();
            if (session == null)
            {
                return View();
            }
            else if (session != null)
            {
                return View();
            }
            else
            {
                ViewBag.UserName = HttpContext.Session.GetString("UserName");
                return View();
            }
        }
    }
}
