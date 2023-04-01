using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Asistencia2.Validation;

namespace Asistencia2
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CValidate validate = new CValidate();
            Boolean res =  validate.Verificar(txtUsuario, txtPassword1, lblnivel, lblstatus, lblidpersonal);
            if(res)
            {
                CAsistencia asistencia = new CAsistencia();
                asistencia.AsistenciaIngreso(1, lblidpersonal.Text, 1);


                Datos datos = new Datos();

                datos.lblNivel.Text = lblnivel.Text;
                datos.lblIdpersonal.Text = lblidpersonal.Text;
                
                datos.Show();

                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Incorrecto");
            }
            
        }

        private void txtPassword(object sender, EventArgs e)
        {

        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;//elimina el sonido
                txtPassword1.Select();
            }
        }

        private void txtPassword1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;//elimina el sonido
                button1_Click(sender, e);//llama al evento click del boton
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CValidate validate = new CValidate();
            Boolean res = validate.Verificar(txtUsuario, txtPassword1, lblnivel, lblstatus, lblidpersonal);

            if (res)
            {
                CAsistencia asistencia = new CAsistencia();
                asistencia.AsistenciaSalida(1, lblidpersonal.Text, 1);
    
                this.Show();
            }
            else
            {
                MessageBox.Show("Incorrecto");
            }
        }
    }
}
