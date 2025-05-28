using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Entidades
{
    internal class E_Actividad
    {
        public int IDActividad { get; set; }
        public string Nombre { get; set; }
        public string DiaSemana { get; set; }
        public TimeSpan Hora { get; set; }
        public decimal Precio { get; set; }

        public string NombreYDia => $"{Nombre} - {DiaSemana}";
    }
}
