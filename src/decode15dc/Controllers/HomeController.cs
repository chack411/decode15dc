﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace decode15.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
#if DNX451
            ViewBag.ServerName = Environment.MachineName;
#else
            ViewBag.ServerName = "";
#endif
            return View();
        }
    }
}
