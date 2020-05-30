using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using PetStoreFinalTest.Models;
using DocumentFormat.OpenXml.Wordprocessing;

namespace PetStoreFinalTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly Settings _settings;
        public HomeController(IOptionsSnapshot<Settings> settings)
        {
            _settings = settings.Value;
        }
        public IActionResult Index()
        {
            ViewData["BackgroundColor"] = _settings.DisplayBackgroundShape;
            //ViewData["FontSize"] = _settings.FontSize;
            //ViewData["FontColor"] = _settings.FontColor;
            //ViewData["Message"] = _settings.Message;
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
    }
}
