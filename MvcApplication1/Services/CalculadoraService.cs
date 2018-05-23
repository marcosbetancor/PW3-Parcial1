using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcApplication1.Models;

namespace MvcApplication1.Services
{
    public class CalculadoraService
    {

        public static List<Operacion> operaciones = new List<Operacion>();

        public Operacion Sumar(Operacion o) {

            o.operador = "+";
            o.res = o.a + o.b;

            return o;
        }

        public Operacion Restar(Operacion o)
        {

            o.operador = "-"; 
            o.res = o.a - o.b;

            return o;
        }

        public void AgregarALista(Operacion o)
        {
            if (operaciones.Count > 0)
            {

                o.pos = operaciones.Last().pos + 1;
                operaciones.Add(o);

            }
            else {

                o.pos = 0;

                operaciones.Add(o);
            
            }
        }

        public List<Operacion> Listar() {

            return operaciones;
        }

    }
}