using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuotingDojo.Models;
using DbConnection;
using Microsoft.AspNetCore.Http;

namespace QuotingDojo.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("Index");
        }

        [HttpPost("process")]
        public IActionResult Process(User NewUser)
        {
            if(ModelState.IsValid)
            {
            string query = $"INSERT INTO users (name, quote) VALUES ('{NewUser.Name}', '{NewUser.Quote}')";
            DbConnector.Execute(query);
            return RedirectToAction("Quotes");
            }
            else
            {
                return View("Index");
            }
        }

        [HttpGet("quotes")]
        public IActionResult Quotes()
        {
            ViewBag.Users = DbConnector.Query("SELECT * FROM users");
            return View("Quotes");
        }

    }
}
