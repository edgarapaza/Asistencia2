using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Asistencia2.Validation
{
    class Conexion
    {

        MySqlConnection connection = new MySqlConnection();

        static string servidor = "localhost";
        static string db       = "gonsad";
        static string usuario  = "usuario";
        static string passwd   = "archivo123$";
        //static string puerto   = "3306";

        string connectionString = "server=" + servidor + ";user id=" + usuario + ";password=" + passwd + ";database=" + db + "";


        public MySqlConnection Conectar()
        {

            try
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                //MessageBox.Show("Conexion exitosa");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return connection;
        }

        public void CerrarConexion()
        {
            connection.Close();
        }
    }
}
