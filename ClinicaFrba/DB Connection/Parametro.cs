using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.DB_Connection
{
    class Parametro
    {
        public String nombre {get; set;}
        public Object valor { get; set; }
        
        public Parametro (String nombre, Object valor) {
            this.nombre = nombre;
            this.valor= valor;
        }
    }
}
