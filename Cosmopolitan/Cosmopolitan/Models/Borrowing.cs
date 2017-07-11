using System.ComponentModel.DataAnnotations;

namespace Cosmopolitan.Models
{
    public class Borrowing
    {
        [Display(Name = "Finalidad del Préstamo")]
        public BasicField<string> Finalidad { get; set; }

        [Display(Name = "Tipo de Préstamo")]
        public BasicField<string> Tipo { get; set; }

        [Display(Name = "Tipo de Trámite")]
        public BasicField<string> Tramite { get; set; }

        [Display(Name = "Antigüedad")]
        public BasicField<string> Antiguedad { get; set; }

        [Display(Name = "Tipo de Garantía")]
        public BasicField<string> Garantia { get; set; }
    }
}
