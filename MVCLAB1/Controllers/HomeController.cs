using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCLAB1.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVCLAB1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


        public IActionResult MovieForm()
        {
            //nothing special just displaying 
            return View();
        }
        public IActionResult Result(Movie m)
        { 

            return View(m);
        }

        public IActionResult List()
        {
            //nothing special just displaying 
            return View();
        }
        public IActionResult Result2(Movie m)
        {

            return View(m);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
