using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gimnasio.Views
{
    public partial class Register : Form
    {
        bool compruebaregistro=false;//para comprobar que todos los campos de registro estén ok y aparezca el boton de registrar
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
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
           
        }

        private void compruebaCampos()
        {
            
            if (tbNombre.TextLength!=0 && tbApellidos.TextLength!=0 && tbTelefono.TextLength!=9 && Regex.IsMatch(tbTelefono.Text, "^[0-9]+$") && tbDireccion.TextLength!=0 && Regex.IsMatch(tbDNI.Text, @"^\d{8}[A-Za-z]$") &&
                Regex.IsMatch(tbEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$") && Regex.IsMatch(tbContraseña.Text, @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[%&$/\*])[A-Za-z\d%&$/\*]{8,}$") && tbCuentaCorriente.TextLength>20)
            {
                compruebaregistro = true;
            }
        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
