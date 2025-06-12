//Entidad utilizada para el listado de vencimientos, combina datos de los socios y de las cuotas

using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Entidades
{
    
    public class E_CuotaSocio
    {
        public int IDCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public string Telefono { get; set; }
        public decimal Monto { get; set; }
        public DateTime FechaVencimiento { get; set; }
    }
}
