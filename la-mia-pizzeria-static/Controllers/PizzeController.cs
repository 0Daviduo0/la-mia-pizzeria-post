using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Metrics;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzeController : Controller
    {
        public static List<PizzeList> PizzaDb { get; set; } = new()
        {
            new PizzeList (
                "Peppa pig",
                "Pizza con impasto di Peppa Pig e forma di Peppa Pig",
                "https://i.ytimg.com/vi/x0aAA_37mD8/hqdefault.jpg",
                350, 
                1
                ),
            new PizzeList (
                "Pizza completa",
                "Pizza completa incredibile con tutte le cose migliori da mettere su una pizza",
                "https://i.kym-cdn.com/photos/images/original/002/166/877/9a7.jpg",
                19,
                2
                ),
            new PizzeList (
                "Pizza Hut",
                "Pizza mascotte della famosissima marca di Pizza Hut",
                "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSDaBGy_M1LMEmyrry1BEtGx3V_B-Vzvf7_eA&usqp=CAU",
                99,
                3
                ),

        };
        public IActionResult Index()
        {
            if (PizzaDb.Count == 0)
            {
                return View("Error", "Non ci sono pizze");
            }
            return View(PizzaDb);
        }

        public IActionResult Details(int Id)
        {
            var counter = PizzaDb.FirstOrDefault(p => p.Id == Id);
            if (counter == null){
                return View("Error", "Pizza non trovata");
            }
            return View(counter);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(PizzeList data)
        {
            if (!ModelState.IsValid)
                return View("Create", data);

            PizzaDb.Add(data);

            return RedirectToAction("Index");
        }


    }
}
