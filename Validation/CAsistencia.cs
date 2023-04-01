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

        public void AsistenciaIngreso(int periodo, string idpersonal, int llamada)
        {
            string asis = "p";
            double descuento = 0;


            string dia = DateTime.Now.ToString("yyyy-MM-dd");
            string hora_in = DateTime.Now.ToString("hh:mm:ss");
            Console.WriteLine(periodo);
            Console.WriteLine(idpersonal);
            Console.WriteLine(llamada);
            Console.WriteLine(dia);
            Console.WriteLine(hora_in);


            try
            {
                string consulta = "INSERT INTO asistencia VALUES (null,'"+periodo+"','"+ idpersonal + "','"+dia+"','"+ hora_in + "','00:00:00','" + asis + "','"+ llamada + "','"+ descuento + "')";
                MySqlCommand cmd = new MySqlCommand(consulta, conn.Conectar());
                cmd.ExecuteNonQuery();
                conn.CerrarConexion();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public void AsistenciaSalida(int periodo, string idpersonal, int llamada)
        {
            string asis = "p";
            double descuento = 0;


            string dia = DateTime.Now.ToString("yyyy-MM-dd");
            string hora_out = DateTime.Now.ToString("hh:mm:ss");
            Console.WriteLine(periodo);
            Console.WriteLine(idpersonal);
            Console.WriteLine(llamada);
            Console.WriteLine(dia);
            Console.WriteLine(hora_out);


            try
            {
                string consulta = "UPDATE asistencia SET hora_out = '"+ hora_out + "' WHERE idasistencia = '2' AND dia = '"+ dia + "';";
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
