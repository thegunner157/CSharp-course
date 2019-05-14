using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KarolStulaLab4.Models;

namespace KarolStulaLab4.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Lista aut do wyswietlenia
        /// </summary>
        List<CarViewModel> allCars;
        public HomeController()
        {
            allCars = new List<CarViewModel>();
            allCars.Add(new CarViewModel("Focus", "Ford", 72000, "~/focus.png"));
            allCars.Add(new CarViewModel("Golf", "Volkswagen", 80000, "~/golf.png"));
            allCars.Add(new CarViewModel("Civic", "Honda", 82000, "~/civic.png"));
            allCars.Add(new CarViewModel("Megane", "Renault", 67000, "~/megane.png"));
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult InterestingLinks()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GetAllCars()
        {
            return View(allCars);
        }
        [HttpGet]
        public IActionResult GetListOfModels()
        {
            //Lista nazw modeli samochodow
            List<string> allModels = new List<string>();
            //Petla dodajaca modele
            foreach(CarViewModel car in allCars)
            {
                allModels.Add(car.Model);
            }
            //Przekazanie listy do widoku
            return View(allModels);
        }
        /// <summary>
        /// Pobieranie auta po modelu
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetCarByModel(string model)
        {
            // Wyszukiwanie samochodu w liscie
            CarViewModel car = allCars.Where(a => a.Model.ToLower() == model.ToLower()).FirstOrDefault();
            // Przekazanie obiektu do widoku
            return View(car);
        }
        /// <summary>
        /// Wyswietlane formularza kontaktowego
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult ContactForm()
        {
            return View();
        }
        /// <summary>
        /// Wyswietlenie powitania po wyswietlenia formularza kontaktowego
        /// </summary>
        /// <param name="userData"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult ContactForm(ContactFormViewModel userData)
        {
            string fullName = userData.FirstName + " " + userData.LastName;
            ViewBag.UserName = fullName;
            return View("ContactFormGreetings");
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
