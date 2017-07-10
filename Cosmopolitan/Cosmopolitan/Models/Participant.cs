using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cosmopolitan.Models
{
    /// <summary>
    /// Individuo Natural o jurídico que participa
    /// en la adquicisión del
    /// </summary>
    public class Participant
    {
        public string Name { get; set; }

        public string LastName { get; set; }

        /// <summary>
        /// Cédula: Natural, Jurídica, etc.
        /// </summary>
        public string Identification { get; set; }

        public string Telephone { get; set; }

        public DateTime Birthdate { get; set; }

        /// <summary>
        /// Si tiene seguro de vida
        /// </summary>
        public bool HasLifeInsurance { get; set; }

        public string Job { get; set; }

        /// <summary>
        /// El salario y los gastos de representación
        /// </summary>
        public decimal SalaryPlusRepresentationExpenses { get; set; }

    }
}
