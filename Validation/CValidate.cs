using MySql.Data.MySqlClient;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace Asistencia2.Validation
{
    public class CValidate
    {
        Conexion conn = new Conexion();


        public int Login(TextBox user, TextBox passwd, Label nivel, Label status, Label idpersonal)
        {

            CAsistencia asistencia = new CAsistencia();

            int estado = 0;
            int nivel_id = 0;
            string id_personal = null;
            


            try
            {
                string consulta = "SELECT idlogin,idpersonal,nivel,activo FROM gonsad.asistencia_login WHERE loginname = '" + user.Text + "' AND passwd = '" + passwd.Text + "'";
                MySqlCommand cmd = new MySqlCommand(consulta, conn.Conectar());
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    nivel_id = reader.GetInt32(2);
                    estado = reader.GetInt32(3);
                    id_personal = reader.GetString(1);

                    nivel.Text = reader.GetString(2);
                    status.Text = reader.GetString(3);
                    idpersonal.Text = reader.GetString(1);


                    if (estado == 1)
                    {
                        switch (nivel_id)
                        {
                            case 1:
                                Console.WriteLine("administrador");
                                //AsistenciaAdministrador();
                                break;
                            case 2:
                                Console.WriteLine("Jefe");
                                //AsistenciaJefe();
                                break;
                            case 3:
                                Console.WriteLine("Personal");
                                int total = asistencia.VerificarAsistencia(id_personal);
                                

                                if (total > 0)
                                {
                                    MessageBox.Show("Reingresando a la Aplicación");
                                    asistencia.RegistraBitacora(id_personal);
                                }
                                else
                                {
                                    Console.WriteLine("Primer registro del dia");
                                    asistencia.RegistraBitacora(id_personal);
                                }

                                break;
                            default:
                                Console.WriteLine("Opcion No reconocida");
                                break;
                        }

                        estado = 1;
                    }
                    else
                    {
                        MessageBox.Show("EL USUARIO NO TIENE PERMISO PARA INGRESAR A LA APLICACION");
                        estado = 0;
                    }

                    
                }
                reader.Close();
                conn.CerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error Login: " + e.ToString());
            }

            return estado;
        }

        

    }
}