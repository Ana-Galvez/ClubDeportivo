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
                //Datos entrada
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
    }
}
