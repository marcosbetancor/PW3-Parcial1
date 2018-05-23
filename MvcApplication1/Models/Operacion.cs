using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcApplication1.Models
{
    public class Operacion
    {
        [Required(ErrorMessage="Entero obligatorio")]
        [Range(0,1000, ErrorMessage="Fuera de rango")]
        public int a { get; set; }
        
        [Required(ErrorMessage="Entero obligatorio")]
        [Range(0, 1000, ErrorMessage="Fuera de rango")]
        public int b { get; set; }
        public int res { get; set; }
        public string operador { get; set; }

    }
}