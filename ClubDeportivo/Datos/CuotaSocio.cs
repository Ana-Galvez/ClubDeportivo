using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClubDeportivo.Entidades;
using MySql.Data.MySqlClient;

namespace ClubDeportivo.Datos
{

    public class CuotaSocio
    {        
        //Fc para obtener el listado de E_CuotaSocio que vencen el día de hoy
        public static List<E_CuotaSocio> ObtenerCuotasVencidasHoy()
        {
            var lista = new List<E_CuotaSocio>();

            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
            {
                sqlCon.Open();
                //join entre las cuotas y lso clientes que son socio
                string query = @"SELECT c.IDCliente, cli.Nombre, cli.Apellido, cli.DNI, cli.Telefono,
                   c.Monto, c.FechaVencimiento FROM cuotas c INNER JOIN cliente cli ON cli.IDCliente = c.IDCliente WHERE c.Estado = 'Pendiente' AND c.FechaVencimiento = CURDATE();";

                using (var cmd = new MySqlCommand(query, sqlCon))
                using (var reader = cmd.ExecuteReader())
                {
                    //cargo el resultado en una lista de E_CuotaSocio
                    while (reader.Read())
                    {
                        lista.Add(new E_CuotaSocio
                        {
                            IDCliente = reader.GetInt32("IDCliente"),
                            Nombre = reader.GetString("Nombre"),
                            Apellido = reader.GetString("Apellido"),
                            DNI = reader.GetInt32("DNI"),
                            Telefono = reader.GetString("Telefono"),
                            Monto = reader.GetDecimal("Monto"),
                            FechaVencimiento = reader.GetDateTime("FechaVencimiento")
                        });
                    }
                }
            }

            return lista;
        }

    }
}
