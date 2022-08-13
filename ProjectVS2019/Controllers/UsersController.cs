using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjectVS2019.Data;
using ProjectVS2019.Models;

namespace ProjectVS2019.Controllers
{
    public class UsersController : Controller
    {
        private readonly ProjectVS2019Context _context;

        public UsersController(ProjectVS2019Context context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Registration()
        {
            return View("Privacy");
        }

        [HttpPost]
        public IActionResult CreateUser(string firstName, string lastName)
        {
            User u = new User() { FirstName = firstName, LastName = lastName };
            _context.Add(u);
            _context.SaveChanges();
            return View("Region");
        }

        [HttpPost]
        public IActionResult ChoiseRegion ()
        {
            return View("Vote");
        }

        [HttpPost]
        public IActionResult ChoiseVote()
        {
            return View("Candidate");
        }

        [HttpPost]
        public IActionResult ChoiseCandidate()
        {
            return View("Thanks");
        }
    }
}
