using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Cosmopolitan.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Cosmopolitan.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Quotation model = new Quotation {
                Programa = LoadProgram(),
                Borrow = LoadBorrowing()
            };
            

            return View(model);
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

        public IActionResult Error()
        {
            return View();
        }


        /// <summary>
        /// Rellena información sobre qué programas 
        /// se utilizan en la cotización
        /// </summary>
        /// <returns></returns>
        private BasicField<string> LoadProgram()
        {
            return new BasicField<string>
            {
                Collection = new List<SelectListItem> {
                    new SelectListItem { Text = "BG", Value = "BG" },
                    new SelectListItem { Text = "Feria", Value = "Feria", Selected = true },
                    new SelectListItem { Text = "Otros", Value = "Otros" }
                }
            };
        }

        private Borrowing LoadBorrowing()
        {
            return new Borrowing {
                Finalidad = new BasicField<string>
                {
                    Name= "Fidelidad", Collection = new List<SelectListItem>
                    {
                        new SelectListItem { Text=""}
                    }
                }
            };
        }
    }
}
