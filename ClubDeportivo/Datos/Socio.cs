using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Datos
{
    internal class Socio
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreCompleto => $"{Nombre} {Apellido}";
        public bool EsSocio { get; set; }
        public DateTime? FechaAltaSocio { get; set; }
    }
}
