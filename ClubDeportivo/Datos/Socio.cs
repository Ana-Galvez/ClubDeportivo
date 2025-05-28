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
        public static DataTable ObtenerCuotasImpagas(int idCliente)
        {
            DataTable tabla = new DataTable();
            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
            {
                sqlCon.Open();
                string query = @"SELECT IdCuota, FechaVencimiento, Monto
                                 FROM cuotas 
                                 WHERE IDCliente = @id AND Estado = 'Pendiente'";
                using (MySqlCommand cmd = new MySqlCommand(query, sqlCon))
                {
                    cmd.Parameters.AddWithValue("@id", idCliente);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(tabla);
                }
            }
            return tabla;
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
