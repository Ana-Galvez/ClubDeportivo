using ClubDeportivo.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Datos
{
    internal class NoSocio
    {
        //obtener listado de actividades
    public static List<E_Actividad> ObtenerActividades()
    {
        List<E_Actividad> actividades = new List<E_Actividad>();

        using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
        {
            sqlCon.Open();
            string query = @"SELECT IDActividad, Nombre, DiaSemana, Hora, Precio FROM actividades";

            using (MySqlCommand cmd = new MySqlCommand(query, sqlCon))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var actividad = new E_Actividad
                    {
                        IDActividad = reader.GetInt32("IDActividad"),
                        Nombre = reader.GetString("Nombre"),
                        DiaSemana = reader.GetString("DiaSemana"),
                        Hora = reader.GetTimeSpan("Hora"),
                        Precio = reader.GetDecimal("Precio")
                    };
                    actividades.Add(actividad);
                }
            }
        }

        return actividades;
    }
        public static void RegistrarPagoActividad(int idCliente, int idActividad, DateTime fechaPago, decimal monto)
        {
            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
            {
                sqlCon.Open();
                string query = @"INSERT INTO pago_actividad 
                         (IDCliente, IdActividad, FechaPago, Monto, Estado)
                         VALUES (@idCliente, @idActividad, @fechaPago, @monto, 'Pagada')";
                using (MySqlCommand cmd = new MySqlCommand(query, sqlCon))
                {
                    cmd.Parameters.AddWithValue("@idCliente", idCliente);
                    cmd.Parameters.AddWithValue("@idActividad", idActividad);
                    cmd.Parameters.AddWithValue("@fechaPago", fechaPago);
                    cmd.Parameters.AddWithValue("@monto", monto);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
