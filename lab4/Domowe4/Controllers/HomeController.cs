using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Domowe4.Models;

namespace Domowe4.Controllers
{
    public class HomeController : Controller
    {
        List<MonumentsModel> allMonuments;
        List<AttractionsModel> allAttractions;
        public HomeController()
        {
            allAttractions = new List<AttractionsModel>();
            allMonuments = new List<MonumentsModel>();
            allMonuments.Add(new MonumentsModel(445, "Ratusz miejski", "ratusz.png", "70%"));
            allMonuments.Add(new MonumentsModel(425, "Kościół św. Michała", "michal.png", "100%"));
            allMonuments.Add(new MonumentsModel(256, "Zbór braci Morawskich", "zbor.png", "40%"));
            allMonuments.Add(new MonumentsModel(138, "Podnoszony most", "most.png", "60%"));
            allAttractions.Add(new AttractionsModel(0, "Park Krasnala", "krasnal.jpg", "8.00-21.00"));
            allAttractions.Add(new AttractionsModel(30, "Park Linowy", "linowy.jpg", "9.00-18.00"));
            allAttractions.Add(new AttractionsModel(0, "Port miejski", "port.jpg", "Whole day"));
            allAttractions.Add(new AttractionsModel(5, "Świat wodny", "wodny.jpg", "8.00-20.00"));
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GetallAttractions()
        {
            return View(allAttractions);
        }

        public IActionResult InterestingLinks()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GetMessage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult GetMessage(MessageViewModel userData)
        {
            ViewBag.UserName = userData.Name;
            //ViewBag.UserMessage = userData.Message;
            return View("MessagePresentasion");
        }
        [HttpGet]
        public IActionResult GetListofMonuments()
        {
            List<string> allPlaces = new List<string>();
            foreach(MonumentsModel mon in allMonuments)
            {
                allPlaces.Add(mon.Name);
            }
            return View(allPlaces);
        }

        [HttpGet]
        public IActionResult GetMonumentByModel(string name)
        {
            // Wyszukiwanie samochodu w liscie
            MonumentsModel monument = allMonuments.Where(a => a.Name.ToLower() == name.ToLower()).FirstOrDefault();
            // Przekazanie obiektu do widoku
            return View(monument);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
