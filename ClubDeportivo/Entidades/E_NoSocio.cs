using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Entidades
{
    internal class E_NoSocio : E_Cliente
    {
        public List<E_PagoActividad> Pagos { get; set; } = new(); 
    }
}
