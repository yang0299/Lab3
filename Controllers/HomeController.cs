using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Lab3.Models;
using Microsoft.AspNetCore.Http;
namespace Lab3.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Razor()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Count()
        {
            
        //    var number = Convert.ToInt32(Request.Form["num"]);
           // ViewData["num"] = number;
            ViewData["num"] = Convert.ToInt32(Request.Form["num"]);
            return View();
        }
        [HttpPost]
        public IActionResult PlayAgain()
        {
            return View("Razor");
        }

        [HttpGet]
        public IActionResult CreatePerson()
        {
            return View();
        }
        [HttpPost]
        public IActionResult DisplayPerson(Person person)
        {
            return View(person);
        }
        [HttpGet]
        public IActionResult Error()
        {
            return View();
        }
    }
}
