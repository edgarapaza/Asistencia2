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
        public void Verificar(TextBox user, TextBox passwd)
        {
            MessageBox.Show("Dentro: " + user.Text+ " pass:  " + passwd.Text);
        }
    }
}
