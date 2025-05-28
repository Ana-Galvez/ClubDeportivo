using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Entidades
{
    internal class E_Cuota
    {
        public int IdCuota { get; set; }
        public int IdCliente { get; set; }
        public decimal Monto { get; set; }
        public string ModoPago { get; set; }
        public string Estado { get; set; }
        public DateTime FechaPago { get; set; }
        public DateTime FechaVencimiento { get; set; }

        //Sobreescribo para obtener todos los datos relevantes del pago de cuota
        public override string ToString()
        {
            return $"Cuota {IdCuota} - Vence {FechaVencimiento:dd/MM/yyyy} - ${Monto}";
        }
    }
}
