using BirthdayCalculator.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BirthdayCalculator.Controllers
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
        [HttpGet]
        public IActionResult BirthdayForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult BirthdayForm(BirthDateModel birthDateModel)
        {
            if (ModelState.IsValid)
            {
                // dit is eigenlijk niet eens nodig voor deze opdracht, oeps
                BirthDateRepository.AddBirthDate(birthDateModel);

                if (birthDateModel.BirthDate.Day == DateTime.UtcNow.Day)
                {
                    // Return birthday als de verjaardag vandaag is
                    return View("Birthday", birthDateModel);
                }
                else
                {
                    // Geef ook het verschil mee via een viewbag
                    ViewBag.DifferenceInDays =   birthDateModel.BirthDate.Day - DateTime.UtcNow.Day;
                    // return notbirthday als de verjaardag niet is
                    return View("NotBirthday", birthDateModel);
                }
            }
            else
            {
                // Return dezelfde view als de modelstate niet valid is
                return View();
            }
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
