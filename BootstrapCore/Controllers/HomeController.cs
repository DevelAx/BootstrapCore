﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BootstrapCore.Models.Home;

namespace BootstrapCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(HelloModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            return View("GreetUser", model);
        }
    }
}