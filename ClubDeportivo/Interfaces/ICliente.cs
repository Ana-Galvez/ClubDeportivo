using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Interfaces
{
    public interface ICliente
    {
        int IDCliente { get; }
        string Nombre { get; }
        string Apellido { get; }
        bool Socio { get; }
    }
}
