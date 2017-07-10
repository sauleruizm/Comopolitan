using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

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
        public decimal PrecioDeVenta { get; set; }

        /// <summary>
        /// Valor en porcentaje
        /// </summary>
        public decimal Financiamiento { get; set; }

        public decimal AbonoInicial { get; set; }

        public decimal MontoAFinanciar { get; set; }

        /// <summary>
        /// En porcentaje
        /// </summary>
        public decimal TaseDeInteres { get; set; }

        public decimal ComisionDeCierre { get; set; }

        public decimal BonoGastosLegales { get; set; }

        public decimal BonoTotalGastosLegales { get; set; }

        public bool BancoHaceEscritura { get; set; }

        public bool SeguroDeVida { get; set; }

        public bool SeguroDeIncendio { get; set; }

        /// <summary>
        /// Plazo en periodo de años por defecto 30 años
        /// </summary>
        public decimal Plazo { get; set; } = 30;

        public decimal ComisionDeManejo { get; set; }

        /// <summary>
        /// Contiene el capital más el interés
        /// </summary>
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
