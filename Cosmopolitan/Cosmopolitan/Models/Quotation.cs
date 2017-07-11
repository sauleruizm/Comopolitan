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
        /// Indica el tipo de programa
        /// </summary>
        public BasicField<string> Programa { get; set; }

        /// <summary>
        /// Características sobre él préstamos
        /// </summary>
        public Borrowing Borrow { get; set; }

        public string Promotor { get; set; }

        public string Proyecto { get; set; }

        /// <summary>
        /// Precio del inmueble 
        /// </summary>
        [Display(Name = "Precio de Venta/Valor de la Propiedad")]
        public decimal PrecioDeVenta { get; set; }

        /// <summary>
        /// Valor en porcentaje
        /// </summary>
        [Display(Name = "% Financiamiento")]
        public decimal Financiamiento { get; set; }

        [Display(Name = "Bono Inicial Calculado")]
        public decimal AbonoInicialCalculado { get; set; }

        [Display(Name = "Bono Inicial Ingresado")]
        public decimal AbonoInicial { get; set; }

        [Display(Name = "Monto a Financiar")]
        public decimal MontoAFinanciar { get; set; }

        /// <summary>
        /// En porcentaje
        /// </summary>
        [Display(Name = "Tasa de Interés")]
        public decimal TaseDeInteres { get; set; }

        [Display(Name = "Comosión de Cierre")]
        public decimal ComisionDeCierre { get; set; }

        [Display(Name = "Bono Gastos Legales")]
        public decimal BonoGastosLegales { get; set; }

        [Display(Name = "Total de Gastos Legales")]
        public decimal BonoTotalGastosLegales { get; set; }

        [Display(Name = "Banco Hace Escritura")]
        public bool BancoHaceEscritura { get; set; }

        [Display(Name = "Seguro de Vida")]
        public bool SeguroDeVida { get; set; }

        [Display(Name = "Seguro de Incendio")]
        public bool SeguroDeIncendio { get; set; }

        [Display(Name = "FECI")]
        public bool Feci { get; set; }

        /// <summary>
        /// Plazo en periodo de años por defecto 30 años
        /// </summary>
        [Display(Name = "Plazo")]
        public decimal Plazo { get; set; } = 30;

        [Display(Name = "Comisión de Manejo")]
        public decimal ComisionDeManejo { get; set; }

        /// <summary>
        /// Contiene el capital más el interés
        /// </summary>
        [Display(Name = "Capital + Interés")]
        public decimal Capital { get; set; }

        /// <summary>
        /// Dinero que debe pagar el usuario.
        /// </summary>
        public decimal Mensualidad { get; set; }

        /// <summary>
        /// Lista de participantes para el préstamo hipotecario
        /// </summary>
        public BasicField<Participant> Participantes { get; set; }
    }
}
