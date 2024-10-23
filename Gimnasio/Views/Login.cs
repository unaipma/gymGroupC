using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gimnasio.Views
{
    public partial class Login : Form
    {
        
        //comentario prueba
        public Login()
        {
            InitializeComponent();
        }

        private void bAtras_Click(object sender, EventArgs e)
<<<<<<< Updated upstream
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
=======
        {           
            this.Close();
        }

        private void bBorrar_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            textBox2.ResetText();
            lError.ResetText();
        }

        
        private void bAceptar_Click_1(object sender, EventArgs e)
        {
            
           
            string usuario = textBox1.Text;
            string contrasena = textBox2.Text;


            /*   var usuarioReal = equipo_c_db.usuarios
             .Where(u => u.EMAIL == usuario)
             .Select(u => u.EMAIL);

               var contrasenaReal = equipo_c_db.usuarios
            .Where(u => u.EMAIL == usuario)
            .Select(u => u.PASS);
            */

            var usuarioReal = "x";
            var contrasenaReal = "x";



            if (usuarioReal != null && usuarioReal != "")
            {


                if (contrasena == contrasenaReal)
                {
                    AplicacionPrincipal aplicacionPrincipal = new AplicacionPrincipal();
                    this.Close();
                    aplicacionPrincipal.Show();
                    
                }
                else
                {
                    lError.Text = "Contrasena incorrecta";
                }

            }
            else
            {
                lError.Text = "Usuario no existe";
            }
        }
>>>>>>> Stashed changes
    }
}
