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
                string query = @"SELECT IdCuota, IDCliente, Monto, Estado, FechaVencimiento
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
                                Estado = reader.GetString("Estado"),
                                FechaVencimiento = reader.GetDateTime("FechaVencimiento")
                            };
                            cuotas.Add(cuota);
                        }
                    }
                }
            }

            return cuotas;
        }

        public static void RegistrarPagoCuota(int idCuota, DateTime fechaPago,string modoPago, int cantCuotas, int nrosTarjeta)
        {
            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
            {
                sqlCon.Open();
                string query = @"UPDATE cuotas 
                                 SET Estado = 'Pagada', 
                                     FechaPago = @fecha,
                                     ModoPago = @modoPago,
                                     CantCuotas = @cantCuotas,
                                    UltDigitosTarj = @nrosTarjeta
                                 WHERE IdCuota = @idCuota";
                using (MySqlCommand cmd = new MySqlCommand(query, sqlCon))
                {
                    cmd.Parameters.AddWithValue("@fecha", fechaPago);
                    cmd.Parameters.AddWithValue("@idCuota", idCuota);
                    cmd.Parameters.AddWithValue("@modoPago", modoPago);
                    cmd.Parameters.AddWithValue("@cantCuotas", cantCuotas);
                    cmd.Parameters.AddWithValue("@nrosTarjeta", nrosTarjeta);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void CrearPrimerCuota(int idCliente, decimal monto)
        {

            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
            {
                sqlCon.Open();

                string query = @"INSERT INTO cuotas 
                         (IDCliente, Monto, Estado, FechaVencimiento)
                         VALUES (@idCliente, @monto, 'Pendiente', @fechaVencimiento)";

                using (MySqlCommand cmd = new MySqlCommand(query, sqlCon))
                {
                    DateTime fechaVencimiento = DateTime.Today.AddMonths(1);

                    cmd.Parameters.AddWithValue("@idCliente", idCliente);
                    cmd.Parameters.AddWithValue("@monto", monto);
                    cmd.Parameters.AddWithValue("@fechaVencimiento", fechaVencimiento);

                    cmd.ExecuteNonQuery();
                }
            }

        }

        public static void CrearProximaCuota(int idCliente, decimal monto, DateTime fechaVencimiento )
        {

            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
            {
                sqlCon.Open();

                string query = @"INSERT INTO cuotas 
                         (IDCliente, Monto, Estado, FechaVencimiento)
                         VALUES (@idCliente, @monto, 'Pendiente', @fechaVencimiento)";

                using (MySqlCommand cmd = new MySqlCommand(query, sqlCon))
                {
                    cmd.Parameters.AddWithValue("@idCliente", idCliente);
                    cmd.Parameters.AddWithValue("@monto", monto);
                    cmd.Parameters.AddWithValue("@fechaVencimiento", fechaVencimiento);

                    cmd.ExecuteNonQuery();
                }
            }

        }
    }
}
