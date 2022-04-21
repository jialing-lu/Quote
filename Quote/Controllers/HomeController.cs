using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Quote.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Quote.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private QuoteApplicationContext qaContext { get; set; }

        //constructor

        public HomeController(ILogger<HomeController> logger, QuoteApplicationContext someName)
        {
            _logger = logger;
            qaContext = someName;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var applications = qaContext.Responses
                .OrderBy(x => x.Author)
                .ToList();
            return View(applications);
        }
        [HttpPost]
        public IActionResult Index(ApplicationResponse ar)
        {
            return View("RandomQuote", ar);
        }
        [HttpGet]
        public IActionResult EnterQuote ()
        {
            return View();
        }
        [HttpPost]
        public IActionResult EnterQuote(ApplicationResponse ar)
        {
            qaContext.Add(ar);
            qaContext.SaveChanges();
            return View("Confirmation", ar);
        }
        [HttpGet]
        public IActionResult Details(int applicationid)
        {
            var application = qaContext.Responses.Single(x =>x.ApplicationId == applicationid);
            return View("EnterQuote", application);
        }
        [HttpPost]
        public IActionResult Details(ApplicationId blah)
        {
            qaContext.Update(blah);
            qaContext.SaveChanges();
            return View("Index");
        }
    }
}
