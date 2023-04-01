using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asistencia2.Validation
{
    public class CValidate
    {
        Conexion conn = new Conexion();

        public bool Verificar(TextBox user, TextBox passwd, Label nivel, Label status, Label idpersonal)
        {
            string mensaje = null;
            Boolean estado = false;

            try
            {
                string consulta = "SELECT nivel, status, idpersonal FROM login WHERE user_name = '" + user.Text + "' AND pass_name = '" + passwd.Text + "';";
                MySqlCommand cmd = new MySqlCommand(consulta, conn.Conectar());
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    status.Text = reader.GetString(1);

                    if (Int32.Parse(status.Text) == 1)
                    {
                        mensaje = "Asistencia registrada";

                        nivel.Text = reader.GetString(0);
                        idpersonal.Text = reader.GetString(2);

                        estado = true;

                    }
                    else
                    {
                        mensaje = "No esta activado";
                        estado = false;

                    }
                }

                conn.CerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.ToString());
            }

            MessageBox.Show(mensaje);

            return estado;
        }


    }
}