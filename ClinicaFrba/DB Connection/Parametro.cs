using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.DB_Connection
{
    class Parametro
    {
        private string p;
        private int idRol;

        public String nombre {get; set;}
        public String valor{get; set;}

        public Parametro (String nombre, String valor)
        {
            this.nombre = nombre;
            this.valor = valor;
        }

        public Parametro(string p, int idRol)
        {
            // TODO: Complete member initialization
            this.p = p;
            this.idRol = idRol;
        }
    }
}
