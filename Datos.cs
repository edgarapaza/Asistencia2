using Asistencia2.Validation;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asistencia2
{
    public partial class Datos : Form
    {

        Conexion conn = new Conexion();

        public Datos()
        {
            InitializeComponent();

            MostrarNombre(lblIdpersonal.Text);
        }

        public void MostrarNombre(string codigo)
        {

            try
            {
                string consulta = "SELECT CONCAT(nombres,' ',apellidos) as Nombre FROM personal WHERE idpersonal ="+codigo+"";
                MySqlCommand cmd = new MySqlCommand(consulta, conn.Conectar());
                
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lblNombre.Text =  reader.GetString(0);
                }

                conn.CerrarConexion();
                
            }catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
            
        }
    }
}
