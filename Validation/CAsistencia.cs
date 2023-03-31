using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asistencia2.Validation
{
    internal class CAsistencia
    {
        Conexion conn = new Conexion();

        public void Asistencia()
        {
            try
            {
                string consulta = "INSERT INTO asistencia VALUES (null,'idperiodo','idpersonal','dia','hora_in','hora_out','asis','llamada','descuento')";
                MySqlCommand cmd = new MySqlCommand(consulta, conn.Conectar());
                cmd.ExecuteNonQuery();
                conn.CerrarConexion();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
