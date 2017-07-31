using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cosmopolitan.Models
{
    public class Quotation
    {
        /// <summary>
        /// Representa la fecha en que se realiza la cotización
        /// </summary>
        public DateTime Fecha { get; set; } = DateTime.Now;

        /// <summary>
        /// Precio del inmueble 
        /// </summary>
        [Display(Name = "Precio de Venta/Valor de la Propiedad")]
        public double PrecioDeVenta { get; set; }

        /// <summary>
        /// Valor en porcentaje
        /// </summary>
        [Display(Name = "Financiamiento")]
        public double Financiamiento { get; set; }

        [Display(Name = "Abono Inicial Calculado")]
        public double AbonoInicialCalculado { get; set; }

        [Display(Name = "Abono Inicial Ingresado")]
        public double AbonoInicialIngresado { get; set; }

        [Display(Name = "Monto a Financiar")]
        public double MontoAFinanciar { get; set; }

        /// <summary>
        /// En porcentaje
        /// </summary>
        [Display(Name = "Tasa de Interés")]
        public double TaseDeInteres { get; set; }

        [Display(Name = "Tasa de Interés En Dinero")]
        public double TaseDeInteresDinero{ get; set; }

        //[Display(Name = "Comosión de Cierre")]
        //public double ComisionDeCierre { get; set; }

        //[Display(Name = "Bono Gastos Legales")]
        //public double BonoGastosLegales { get; set; }

        //[Display(Name = "Total de Gastos Legales")]
        //public double BonoTotalGastosLegales { get; set; }

        //[Display(Name = "Banco Hace Escritura")]
        //public bool BancoHaceEscritura { get; set; }

        //[Display(Name = "Seguro de Vida")]
        //public bool SeguroDeVida { get; set; }

        //[Display(Name = "Seguro de Incendio")]
        //public bool SeguroDeIncendio { get; set; }

        [Display(Name = "Mensualidad con FECI")]
        public double MensualidadConFeci { get; set; }

        /// <summary>
        /// Plazo en periodo de años por defecto 30 años
        /// </summary>
        [Display(Name = "Plazo")]
        public int Plazo { get; set; } = 30;

        [Display(Name = "Comisión de Manejo")]
        public double ComisionDeManejo { get; set; }

        /// <summary>
        /// Contiene el capital más el interés
        /// </summary>
        [Display(Name = "Capital + Interés")]
        public double Capital { get; set; }

        /// <summary>
        /// Contiene el capital más el interés
        /// </summary>
        [Display(Name = "Capital + Interés + FECI")]
        public double CapitalFeci { get; set; }

        /// <summary>
        /// Dinero que debe pagar el usuario.
        /// </summary>
        public double Mensualidad { get; set; }       
    }
}//Compra de ViviendaIndividualResidencialNuevaApartamentoFERIA000000000100.000