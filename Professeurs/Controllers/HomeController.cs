using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Professeurs.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Professeurs.Controllers
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

        public IActionResult Trombinoscope()
        {
            Etudiant et = new Etudiant(1, "Nokri", "Naoufal", "naoufal@gmail.com", "4 année",0);
            Etudiant et1 = new Etudiant(1, "Erraoui", "Mouad", "Mouad@gmail.com", "4 année", 0);
            Etudiant et2 = new Etudiant(1, "Erraoui", "Saad", "Saad@gmail.com", "4 année", 0);
            Etudiant et3 = new Etudiant(1, "Khriech", "Hafid", "hafid@gmail.com", "4 année", 0);
            Etudiant et4 = new Etudiant(1, "Djaloud", "Mohammed", "DJ@gmail.com", "4 année", 0);
            Etudiant et5 = new Etudiant(1, "Elhachimi", "Yassine", "yh20@gmail.com", "4 année", 0);
            Etudiant et6 = new Etudiant(1, "Touama", "Youssef", "17pixelz@gmail.com", "4 année", 0);
            Etudiant et7 = new Etudiant(1, "Adli", "Bachir", "bachir@gmail.com", "4 année", 0);
            Etudiant et8 = new Etudiant(1, "wecan", "Abtif", "wecan@gmail.com", "4 année", 0);
            List<Etudiant> etus = new List<Etudiant>();
            etus.Add(et);
            etus.Add(et1);
            etus.Add(et2);
            etus.Add(et3);
            etus.Add(et4);
            etus.Add(et5);
            etus.Add(et6);
            etus.Add(et7);
            etus.Add(et8);

            ViewData["etudiants"] = etus;
            return View("Trombinoscope");
        }
       
            

        }
    
    }

