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
               Financiamiento=90,
               TaseDeInteres = 4.5,
               Plazo =30
            };
            

            return View(model);
        }

        public IActionResult Calcular(Quotation viewModel)
        {
            const int FECI = 1;

            //Cuando no se suministra bono inicial
            if (viewModel.PrecioDeVenta>0 && viewModel.Financiamiento>0 && viewModel.AbonoInicialIngresado<=0)
            {
                viewModel.MontoAFinanciar = viewModel.PrecioDeVenta - (viewModel.PrecioDeVenta * (viewModel.Financiamiento / 100));
                viewModel.MontoAFinanciar = 0;
                //Cuando no tenga feci
                double tasaCalculada = ((viewModel.TaseDeInteres) * 365 / 360) / 12;
                int nper = viewModel.Plazo * 12;
                viewModel.Capital = PMT(tasaCalculada, nper, viewModel.MontoAFinanciar);
                //Cuando tenga feci
                tasaCalculada = ((FECI + viewModel.TaseDeInteres) * 365 / 360) / 12;
                viewModel.CapitalFeci = PMT(tasaCalculada, nper, viewModel.MontoAFinanciar);
            }

            return View(viewModel);
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

        /*
         ir - interest rate per month
         np - number of periods (months)
         pv - present value
         fv - future value (residual value)
         type - 0 or 1 need to implement that
         */
        protected double PMT( double ir, int np, double pv, double fv = 0 )
        {
            double pmt = (ir * (pv * Math.Pow((ir + 1), np) + fv)) / ((ir + 1) * (Math.Pow((ir + 1), np) - 1));
            return pmt;

        }
    }
}