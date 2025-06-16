using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClubDeportivo.Datos
{
    public class Conexion
    {
        private string baseDatos;
        private string servidor;
        private string puerto;
        private string usuario;
        private string clave;
        private static Conexion? con = null;

        private Conexion()
        {
            // Variables usadas para la repetición de líneas de código
            bool correcto = false;
            int mensaje;

            // Se crean las var para recibir los datos desde el teclado 
            string T_servidor = "Servidor";
            string T_puerto = "Puerto";
            string T_usuario = "Usuario";
            string T_clave = "Clave";

            // Se utiliza un ciclo con while para volver a repetir el ingreso de datos
            // la var correcta la inicializamos para ingresar al ciclo
            while (correcto != true)
            {
                // Armamos los cuadros de dialogo para el ingreso de datos 
                T_servidor = Microsoft.VisualBasic.Interaction.InputBox("Ingrese servidor", "DATOS DE INSTALACIÓN MySQL");
                T_puerto = Microsoft.VisualBasic.Interaction.InputBox("Ingrese puerto", "DATOS DE INSTALACIÓN MySQL");
                T_usuario = Microsoft.VisualBasic.Interaction.InputBox("Ingrese usuario", "DATOS DE INSTALACIÓN MySQL");
                T_clave = Microsoft.VisualBasic.Interaction.InputBox("Ingrese clave", "DATOS DE INSTALACIÓN MySQL");
                

                // Controlamos que los datos ingresados para acceder a MySQL sean correctos
                mensaje = (int)MessageBox.Show("Su ingreso: " +
                                           "SERVIDOR = " + T_servidor +
                                           " PUERTO = " + T_puerto +
                                           " USUARIO = " + T_usuario +
                                           " CLAVE = " + T_clave,
                                           "AVISO DEL SISTEMA",
                                           MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Question);

                if (mensaje != 6)
                {
                    MessageBox.Show(
                        "USUARIO Y/O CONTRASEÑA INCORRECTA, INTENTE NUEVAMENTE",
                        "MENSAJE DEL SISTEMA",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    correcto = false;
                }
                else
                {
                    /*MessageBox.Show(
                        "¡INGRESO EXITOSO!",
                        "MENSAJE DEL SISTEMA",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    correcto = true;
                    */
                    try
                    {
                        string testConexion = "datasource = " + T_servidor +
                                          ";port = " + T_puerto +
                                          ";username = " + T_usuario +
                                          ";password = " + T_clave +
                                          ";Database = Proyecto";

                        using (var conn = new MySqlConnection(testConexion))
                        {
                            conn.Open();
                            conn.Close();
                            correcto = true;
                        }

                        MessageBox.Show("¡CONEXIÓN EXITOSA!", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al conectar con la base de datos:\n" + ex.Message,
                                        "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        correcto = false;
                    }
                }
            }


            // Reemplazamos los datos concretos por las variables
            this.baseDatos = "Proyecto";
            this.servidor = T_servidor; // "localhost";
            this.puerto = T_puerto; // "3306";
            this.usuario = T_usuario; // "root";
            this.clave = T_clave;    // "";
        }


        // proceso de interacción
        public MySqlConnection CrearConexion()
        {
            // instalamos una conexion
            MySqlConnection? cadena = new MySqlConnection();
            // El bloque try permite controlar errores

            try
            {
                cadena.ConnectionString = "datasource = " + this.servidor +
                                          ";port = " + this.puerto +
                                          ";username = " + this.usuario +
                                          ";password = " + this.clave +
                                          ";Database = " + this.baseDatos;
            }
            catch (Exception ex)
            {
                cadena = null;
                throw;
            }
            return cadena;
        }

        // para evaluar la instancia de la conectividad 
        public static Conexion getInstancia()
        {
            if (con == null)
            {
                con = new Conexion();
            }
            return con;
        }
    }
}
