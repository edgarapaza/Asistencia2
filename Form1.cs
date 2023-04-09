using Asistencia2.Validation;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Asistencia2
{
    public partial class FrmPrincipal : Form
    {

        // Constants used for blocking keys
        private const int WM_SYSKEYDOWN = 0x104;
        private const int VK_TAB = 0x09;
        private const int VK_LWIN = 0x5B;
        private const int VK_RWIN = 0x5C;
        private const int VK_F4 = 0x73;

        // Declare external methods for blocking keys and maximizing the form
        [DllImport("user32.dll")]
        private static extern int GetSystemMenu(int hWnd, bool bRevert);
        [DllImport("user32.dll")]
        private static extern int EnableMenuItem(int hMenu, uint uIDEnableItem, uint uEnable);
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        private int loginAttempts = 0;
        private const int maxAttempts = 3; // Maximum number of login attempts allowed
        public FrmPrincipal()
        {
            InitializeComponent();

            // Disable Windows key
            DisableWindowsKey();

            // Disable ALT + F4
            this.FormClosing += new FormClosingEventHandler(FrmPrincipal_FormClosing);

            // Disable TAB key
            this.KeyDown += new KeyEventHandler(FrmPrincipal_KeyDown);

            // Disable maximizing the form
            //this.MaximizeBox = false;

            LlenarCombo();
            //Process.Start(@"C:\WINDOWS\system32\rundll32.exe", "user32.dll,LockWorkStation");
        }

        private void DisableWindowsKey()
        {
            int hWnd = Process.GetCurrentProcess().MainWindowHandle.ToInt32();
            int hMenu = GetSystemMenu(hWnd, false);
            EnableMenuItem(hMenu, 0x00000012, 0x00000001);
            EnableMenuItem(hMenu, 0x00000001, 0x00000001);
        }

        private void EnableWindowsKey()
        {
            int hWnd = Process.GetCurrentProcess().MainWindowHandle.ToInt32();
            int hMenu = GetSystemMenu(hWnd, false);
            EnableMenuItem(hMenu, 0x00000012, 0x00000000);
            EnableMenuItem(hMenu, 0x00000001, 0x00000000);
        }


        public void LlenarCombo()
        {
            cboAsistencia.Items.Clear();
            cboAsistencia.Items.Add("1ra Asistencia");
            cboAsistencia.Items.Add("2da Asistencia");
            cboAsistencia.Items.Add("3ra Asistencia");
            cboAsistencia.Items.Add("4ta Asistencia");
            cboAsistencia.Items.Add("5ta Asistencia");
            cboAsistencia.Items.Add("6ta Asistencia");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //1. Enviar los datos para que registre la asistencia
            CAsistencia asistencia = new CAsistencia();
            string llamd = lblLlamada.Text;
            int llamada = Int32.Parse(llamd);
            
            asistencia.AsistenciaIngreso(lblidpersonal, llamada);     

            //2. Enviar los datos para la segunda ventana
            Datos datos = new Datos();
            datos.lblNivel.Text = lblnivel.Text;
            datos.lblIdpersonal.Text = lblidpersonal.Text;

            datos.Show();

            this.Hide();

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
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;//elimina el sonido
                btnLogin_Click(sender, e);//llama al evento click del boton
            }

        }

        private void txtUsuario_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                txtPassword1.Focus();
            }
        }

        private void cboAsistencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboAsistencia.SelectedIndex == 0)
            {
                lblHora.Text = "8:00 AM";
                lblLlamada.Text = "1";
                lblUsuario.Visible = true;
                txtUsuario.Visible = true;
                lblPassword.Visible = true;
                txtPassword1.Visible = true;
                btnEntrada.Visible = false;
            }

            if (cboAsistencia.SelectedIndex == 1)
            {
                lblHora.Text = "12:00 AM";
                lblLlamada.Text = "2";
                lblUsuario.Visible = true;
                txtUsuario.Visible = true;
                lblPassword.Visible = true;
                txtPassword1.Visible = true;
                btnEntrada.Visible = false;
            }

            if (cboAsistencia.SelectedIndex == 2)
            {
                lblHora.Text = "2:00 PM";
                lblLlamada.Text = "3";
                lblUsuario.Visible = true;
                txtUsuario.Visible = true;
                lblPassword.Visible = true;
                txtPassword1.Visible = true;
                btnEntrada.Visible = false;
            }
            if (cboAsistencia.SelectedIndex == 3)
            {
                lblHora.Text = "6:00 PM";
                lblLlamada.Text = "4";
                lblUsuario.Visible = true;
                txtUsuario.Visible = true;
                lblPassword.Visible = true;
                txtPassword1.Visible = true;
                btnEntrada.Visible = false;
            }

            if (cboAsistencia.SelectedIndex == 4)
            {
                lblHora.Text = "8:00 PM";
                lblLlamada.Text = "5";
                lblUsuario.Visible = true;
                txtUsuario.Visible = true;
                lblPassword.Visible = true;
                txtPassword1.Visible = true;
                btnEntrada.Visible = false;
            }

            if (cboAsistencia.SelectedIndex == 5)
            {
                lblHora.Text = "11:00 PM";
                lblLlamada.Text = "6";
                lblUsuario.Visible = true;
                txtUsuario.Visible = true;
                lblPassword.Visible = true;
                txtPassword1.Visible = true;
                btnEntrada.Visible = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (loginAttempts >= maxAttempts)
            {
                MessageBox.Show("Usted ha superado el número máximo permitido para ingresar a la aplicación");
                CerrarAplicion();
                return;

            }

            CValidate validate = new CValidate();

            int res = validate.Login(txtUsuario, txtPassword1, lblnivel, lblstatus, lblidpersonal);

            if (res == 1)
            {
                MessageBox.Show("BIENVENIDO");
                btnEntrada.Visible=true;
                EnableWindowsKey();                
            }
            else
            {
                MessageBox.Show("Login Incorrecto. Solo tiene 3 intentos mas.");
                txtUsuario.Text = "";
                txtPassword1.Text = "";
                txtUsuario.Focus();
                btnEntrada.Visible = false;
            }

            loginAttempts++;
        }


        public void CerrarAplicion()
        {
            this.Close();
            this.OnFormClosed(null);
            this.DestroyHandle();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
        }

        private void FrmPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                e.Handled = true;
            }
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_SYSKEYDOWN)
            {
                if (m.WParam.ToInt32() == VK_TAB ||
                    m.WParam.ToInt32() == VK_LWIN ||
                    m.WParam.ToInt32() == VK_RWIN ||
                    m.WParam.ToInt32() == VK_F4)
                {
                    return;
                }
            }

            base.WndProc(ref m);
        }
    }
    
}
