using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asistencia2.Validation
{
    public class Validate
    {

        Conexion conn = new Conexion();

        public void Verificar(TextBox user, TextBox passwd)
        {
            try
            {
                string consulta = "SELECT nivel, status, idpersonal FROM login WHERE user_name ='"+user.Text+"' AND pass_name ='"+passwd.Text+"';";
                MySqlCommand cmd = new MySqlCommand(consulta, conn.Conectar());
                MySqlDataReader reader = cmd.ExecuteReader();
                
                conn.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la Validacion: " + ex.ToString());
            }
        }
    }
}
