using ClubDeportivo.Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Entidades
{
    public class E_Socio : E_Cliente
    {

    }

    public class CuotaImpaga
    {
        public int IdCuota { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public decimal Monto { get; set; }

        public override string ToString()
        {
            return $"Cuota {IdCuota} - Vence {FechaVencimiento:dd/MM/yyyy} - ${Monto}";
        }
    }

    public class DatosSocio
    {
        public string NombreApellido { get; set; }
        public bool EsSocio { get; set; }
    }
}
