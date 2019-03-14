using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SIMPL.Models;

namespace SIMPL.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
        public IActionResult CreateProjects()
        {

            return View();
        }
        public IActionResult ProjectsQueue()
        {

            return View();
        }
        public IActionResult ProjectDetails()
        {

            return View();
        }

        public IActionResult Tasks()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult reports()
        {

            return View();
        }
    }
}
