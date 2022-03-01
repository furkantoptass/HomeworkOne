﻿using HomeworkOne.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HomeworkOne.Controllers
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                //Success True > 
                return View("Login");
                //return SuccessTrue();
            }
            else
            {
                //Success False > 
                return View("Login");
                //return SuccessFalse();
            }
            return View("Login");
        }
        public IActionResult SuccessTrue()
        {
            return StatusCode(StatusCodes.Status200OK);
        }
        public IActionResult SuccessFalse()
        {
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
        

    }
}
