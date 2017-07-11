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

        /// <summary>
        /// Carga los valores por defecto de los campos
        /// del préstamo.
        /// </summary>
        /// <returns></returns>
        private Borrowing LoadBorrowing()
        {
            return new Borrowing {
                Finalidad = new BasicField<string>
                {
                    Name= "Fidelidad", Collection = new List<SelectListItem>
                    {
                        new SelectListItem { Text="Compra de Vivienda", Value ="Vivienda"},
                        new SelectListItem { Text="Compra de Vivienda Vacacional", Value ="Vacacional"}
                    }
                },
                Tipo = new BasicField<string>
                {
                    Name ="Tipo", Collection = new List<SelectListItem>
                    {
                        new SelectListItem { Text="Compra de Vivienda", Value ="Vivienda"},
                        new SelectListItem { Text="Compra de Vivienda Vacacional", Value ="Vacacional"}
                    }
                },
                Tramite = new BasicField<string>
                {
                    Name ="Tramite", Collection = new List<SelectListItem>
                    {
                        new SelectListItem { Text="Residencial", Value ="Residencial"},
                        new SelectListItem { Text="Reposeído (BG)", Value ="Reposeído (BG)"}
                    }
                },
                Antiguedad = new BasicField<string>
                {
                    Name = "Antiguedad",
                    Collection = new List<SelectListItem>
                    {
                        new SelectListItem { Text="Nueva", Value ="Nueva"},
                        new SelectListItem { Text="Usada", Value ="Usada"}
                    }
                },
                Garantia = new BasicField<string>
                {
                    Name = "Garantia",
                    Collection = new List<SelectListItem>
                    {
                        new SelectListItem { Text="Apartamento", Value ="Apartamento"},
                        new SelectListItem { Text="Casa", Value ="Casa"},
                        new SelectListItem { Text="Unidad de Vivienda", Value ="UnidadVivienda"}
                    }
                }
            };
        }

    }
}
