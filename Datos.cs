using Asistencia2.Clases;
using Asistencia2.Validation;
using MySql.Data.MySqlClient;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Asistencia2
{
    public partial class Datos : Form
    {
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern bool EnableMenuItem(IntPtr hMenu, uint uIDEnableItem, uint uEnable);
        const int MF_BYCOMMAND = 0;
        const int MF_DISABLED = 2;
        const int SC_CLOSE = 0xF060;

        [DllImport("user32.dll")]
        static extern bool ExitWindowsEx(uint uFlags, uint dwReason);

        Conexion conn = new Conexion();

        public Datos()
        {
            InitializeComponent();

            Tiempo tiempo = new Tiempo();

            MostrarNombre(lblIdpersonal.Text);
        }

        public void MostrarNombre(string codigo)
        {

            try
            {
                string consulta = "SELECT CONCAT(nombre,' ', apellidos) AS trabajador FROM gonsad_personal WHERE idpersonal =" + codigo + "";
                MySqlCommand cmd = new MySqlCommand(consulta, conn.Conectar());

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lblNombre.Text = reader.GetString(0);
                }

                reader.Close();

                conn.CerrarConexion();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }

        }

        private void Datos_SizeChanged(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.Icon = SystemIcons.Application;
                notifyIcon1.BalloonTipText = "La aplicacion se esta ejecutnado en Segundo plano";
                notifyIcon1.ShowBalloonTip(1000);
            }
            else if(this.WindowState == FormWindowState.Normal)
            {
                
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            notifyIcon1.BalloonTipText = "Fomulario Visible";
            notifyIcon1.ShowBalloonTip(1000);
        }

        private void restaurarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            notifyIcon1.BalloonTipText = "Fomulario Visible";
            notifyIcon1.ShowBalloonTip(1000);
        }

        private void minimizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CAsistencia asistencia = new CAsistencia();
            asistencia.RegistroSalidaDetalle(lblIdpersonal.Text);

            MessageBox.Show("La sesion se cerrará en 10 segundos");
            
            // Esperar 10 segundos
            Thread.Sleep(10000);

            // Cerrar la aplicación
            this.Hide();

            ExitWindowsEx(0, 0);
        }

        private void btnSalirTodo_Click(object sender, EventArgs e)
        {
            
            DialogResult dialogResult = MessageBox.Show("Quieres apagar la PC? (Y/N)", "GONSAD SOFTWARE", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("La computadora se APAGARÁ en 10 segundos");
                Process.Start("shutdown", "/s /t 10");
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Cancelado");
                Process.Start("shutdown", "/a");
            }

        }

        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void Datos_Load(object sender, EventArgs e)
        {
            var sm = GetSystemMenu(Handle, false);
            EnableMenuItem(sm, SC_CLOSE, MF_BYCOMMAND | MF_DISABLED);
        }

        private void Datos_Resize(object sender, EventArgs e)
        {
            var sm = GetSystemMenu(Handle, false);
            EnableMenuItem(sm, SC_CLOSE, MF_BYCOMMAND | MF_DISABLED);
        }

        private void btnOcultar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
