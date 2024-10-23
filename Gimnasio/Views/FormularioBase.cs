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
    public partial class FormularioBase : Form
    {
        public FormularioBase()
        {
            InitializeComponent();
            // Configurar el formulario para que se ejecute en pantalla completa
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
        }
    }
}

