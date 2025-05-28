using ClubDeportivo.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Datos
{
    public class Cliente
    {
        public string Nuevo_Cliente(E_Cliente c)
        {
            string respuesta = "";
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("NuevoCliente", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                //Definición de los parametros
                comando.Parameters.Add("p_Nombre", MySqlDbType.VarChar).Value = c.Nombre;
                comando.Parameters.Add("p_Apellido", MySqlDbType.VarChar).Value = c.Apellido;
                comando.Parameters.Add("p_FechaNacimiento", MySqlDbType.Date).Value = c.FechaNacimiento;
                comando.Parameters.Add("p_DNI", MySqlDbType.Int32).Value = c.DNI;
                comando.Parameters.Add("p_Genero", MySqlDbType.VarChar).Value = c.Genero;
                comando.Parameters.Add("p_Direccion", MySqlDbType.VarChar).Value = c.Direccion;
                comando.Parameters.Add("p_Telefono", MySqlDbType.VarChar).Value = c.Telefono;
                comando.Parameters.Add("p_FechaInscripcion", MySqlDbType.Date).Value = c.FechaInscripcion;
                comando.Parameters.Add("p_AptoFisico", MySqlDbType.Bit).Value = c.AptoFisico;
                comando.Parameters.Add("p_Socio", MySqlDbType.Bit).Value = c.Socio;

                //Salida -> -1 si ya existe el dni en la base de datos
                MySqlParameter respuestaBD = new MySqlParameter("rta", MySqlDbType.Int32);
                respuestaBD.Direction = ParameterDirection.Output;
                comando.Parameters.Add(respuestaBD);

                sqlCon.Open();
                comando.ExecuteNonQuery();
                int resultado = Convert.ToInt32(respuestaBD.Value);
                if (resultado == -1)
                {
                    respuesta = "El cliente ya existe (DNI duplicado).";
                }
                else
                {
                    respuesta = "Cliente creado con ID: " + resultado;
                }
            }
            catch (Exception ex)
            {
                respuesta = "Error: " + ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }

            return respuesta;
        }
        public (bool existe, bool esSocio) VerificarClienteIDYBooleanSocio(int idCliente)
        {
            using var sqlCon = Conexion.getInstancia().CrearConexion();
            using var cmd = new MySqlCommand("VerificarClienteIDYBooleanSocio", sqlCon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("p_ClienteID", idCliente);

            sqlCon.Open();
            using var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                bool esSocio = !reader.IsDBNull(reader.GetOrdinal("EsSocio")) && reader.GetBoolean("EsSocio");

                return (true, esSocio);
            }
            return (false, false);
        }
        public static bool ValidarYProcesarIdCliente(string textoId, out int idCliente)
    {
        idCliente = 0;
        textoId = textoId?.Trim();

        if (string.IsNullOrWhiteSpace(textoId))
        {
            MessageBox.Show("Debe ingresar ID del cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (!int.TryParse(textoId, out idCliente))
        {
            MessageBox.Show("El ID del cliente debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        return true;
    }
        public static string ObtenerDatosCliente(int idCliente)
        {
            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
            {
                sqlCon.Open();
                string query = "SELECT CONCAT(Nombre, ' ', Apellido) AS NombreCompleto FROM cliente WHERE IDCliente = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, sqlCon))
                {
                    cmd.Parameters.AddWithValue("@id", idCliente);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader.GetString("NombreCompleto");
                        }
                    }
                }
            }
            return null;
        }

    }
}