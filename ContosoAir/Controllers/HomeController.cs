using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ContosoAir.Models;
using System.Text.Json;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;

namespace ContosoAir.Controllers
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
            IndexViewModel model = new IndexViewModel();



            model.Destinations = Utils.loadData<Destination[]>("data/destinations.json");
            model.Deals = Utils.loadData<Deal[]>("data/deals.json").Take(4).ToArray();
            return View(model);
        }

        public IActionResult Book()
        {
            BookViewModel model = new BookViewModel();

            model.Airports = Utils.loadData<Airport[]>("data/airports.json");
            model.Today = DateTime.Now.ToShortDateString();
            return View(model);
        }

        public IActionResult Flight()
        {
            FlightViewModel model = new FlightViewModel();

            model.From = "LIMA";
            model.To = "AREQUIPA";

            model.departs = Utils.loadData<Flight[]>("data/flights.json").Take(8).ToArray();
            model.returns = Utils.loadData<Flight[]>("data/flights.json").Take(8).ToArray();
            return View(model);
        }
        [HttpPost]
        public IActionResult Booked(FlightViewModel model)
        {

            return RedirectToAction("Booked", "Home");
        }

        public IActionResult Booked()
        {
            BookedViewModel[] model = new BookedViewModel[1];
            model[0] = new BookedViewModel
            {
                Returning = Utils.loadData<Flight[]>("data/flights.json").First(),
                Parting = Utils.loadData<Flight[]>("data/flights.json").First()
            };
            return View(model);
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
