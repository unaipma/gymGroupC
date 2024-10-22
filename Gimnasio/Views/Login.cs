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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void bAtras_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void bBorrar_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            textBox2.ResetText();
        }
    }
}
