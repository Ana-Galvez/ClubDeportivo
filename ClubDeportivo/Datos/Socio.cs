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
    internal class Socio : Cliente
    {
        public static List<E_Cuota> ObtenerCuotasImpagas(int idCliente)
        {
            List<E_Cuota> cuotas = new List<E_Cuota>();

            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
            {
                sqlCon.Open();
                string query = @"SELECT IdCuota, IDCliente, Monto, ModoPago, Estado, FechaPago, FechaVencimiento
                         FROM cuotas 
                         WHERE IDCliente = @id AND Estado = 'Pendiente'";

                using (MySqlCommand cmd = new MySqlCommand(query, sqlCon))
                {
                    cmd.Parameters.AddWithValue("@id", idCliente);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var cuota = new E_Cuota()
                            {
                                IdCuota = reader.GetInt32("IdCuota"),
                                IdCliente = reader.GetInt32("IDCliente"),
                                Monto = reader.GetDecimal("Monto"),
                                ModoPago = reader.IsDBNull(reader.GetOrdinal("ModoPago")) ? null : reader.GetString("ModoPago"),
                                Estado = reader.GetString("Estado"),
                                FechaPago = reader.IsDBNull(reader.GetOrdinal("FechaPago")) ? DateTime.MinValue : reader.GetDateTime("FechaPago"),
                                FechaVencimiento = reader.GetDateTime("FechaVencimiento")
                            };
                            cuotas.Add(cuota);
                        }
                    }
                }
            }

            return cuotas;
        }



        public static void RegistrarPagoCuota(int idCuota, DateTime fechaPago)
        {
            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
            {
                sqlCon.Open();
                string query = @"UPDATE cuotas 
                                 SET Estado = 'Pagada', 
                                     FechaPago = @fecha 
                                 WHERE IdCuota = @idCuota";
                using (MySqlCommand cmd = new MySqlCommand(query, sqlCon))
                {
                    cmd.Parameters.AddWithValue("@fecha", fechaPago);
                    cmd.Parameters.AddWithValue("@idCuota", idCuota);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
