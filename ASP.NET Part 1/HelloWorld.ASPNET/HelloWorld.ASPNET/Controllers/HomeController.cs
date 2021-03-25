using HelloWorld.ASPNET.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld.ASPNET.Controllers
{
    public class HomeController : Controller
    {
        // fields
        private readonly ILogger<HomeController> _logger;

        // constructors
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // public IActionResult Index()
        // {
        //     return View();
        // }

        public IActionResult Index()
        {
            int hour = DateTime.Now.Hour;
            string greeting;
            if (hour < 12)
            {
                greeting = "Good Morning";
            }
            else if (hour < 17)
            {
                greeting = "Good Afternoon";
            }
            else
            {
                greeting = "Good Evening";
            }
            return View("HelloWorld", greeting);
        }

        public IActionResult Foo()
        {
            return View();
        }

        public IActionResult Bar()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
