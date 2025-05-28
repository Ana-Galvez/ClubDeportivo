using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Entidades
{
    internal class E_PagoActividad
    {
        public int IDPagoActividad { get; set; }
        public int IDCliente { get; set; }
        public int IDActividad { get; set; }
        public DateTime FechaPago { get; set; }
        public decimal Monto { get; set; }
        public string ModoPago { get; set; } = "Efectivo";

        public E_Actividad Actividad { get; set; }
    }
}
