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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text != "")
            {
                if(txtPassword.Text != "")
                {
                    Validate validate = new Validate();
                    validate.Verificar(txtUsuario, txtPassword);
                }
                else
                {
                    MessageBox.Show("Debe llenar su contraseña");
                }
                
            }
            else
            {
                MessageBox.Show("Usuario Vacio");
            }
            
        }
    }
}
