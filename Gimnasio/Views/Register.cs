using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gimnasio.Views
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txApellidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            tbNombre.ResetText();
            tbApellidos.ResetText();
            tbTelefono.ResetText();
            tbDireccion.ResetText();
            tbDNI.ResetText();
            tbEmail.ResetText();    
            tbCuentaCorriente.ResetText();  
            tbRepiteContraseña.ResetText(); 
            tbContraseña.ResetText();

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {

        }
    }
}
