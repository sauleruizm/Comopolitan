using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Cosmopolitan.Models
{
    /// <summary>
    /// Usada para cargar propiedades en un modelo
    /// especialmente cuando se tienen que llenar los
    /// distintos valores desde el controller 
    /// </summary>
    /// <typeparam name="T">Representa el tipo de datos que manejará la variable</typeparam>
    public class BasicField<T> where T :class
    {
        /// <summary>
        /// Nombre del control en el mvc, view
        /// </summary>
        /// <remarks>
        /// Al leer el modelo este será el campo que contenga el valor
        /// </remarks>
        public T Name { get; set; }

        /// <summary>
        /// Colección de datos que se utilizarán para cargar las listas etc.
        /// </summary>
        public List<SelectListItem> Collection { get; set; }

        /// <summary>
        /// Atributos que se definirán desde el controller.
        /// Cuando sea condicional las clases
        /// </summary>
        public object HtmlAttributes { get; set; }
    }
}
