namespace Gimnasio.Views
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblCuentaCorriente = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblRepiteContraseña = new System.Windows.Forms.Label();
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.tbCuentaCorriente = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbContraseña = new System.Windows.Forms.TextBox();
            this.tbRepiteContraseña = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(480, 355);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Registrar";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Visible = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(384, 355);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 1;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(287, 355);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 2;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(337, 48);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(186, 20);
            this.tbNombre.TabIndex = 3;
            this.tbNombre.TextChanged += new System.EventHandler(this.tbNombre_TextChanged);
            // 
            // tbApellidos
            // 
            this.tbApellidos.Location = new System.Drawing.Point(337, 82);
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.Size = new System.Drawing.Size(186, 20);
            this.tbApellidos.TabIndex = 4;
            this.tbApellidos.TextChanged += new System.EventHandler(this.txApellidos_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(259, 51);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(57, 13);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "NOMBRE:";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(247, 89);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(69, 13);
            this.lblApellidos.TabIndex = 6;
            this.lblApellidos.Text = "APELLIDOS:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(249, 121);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(67, 13);
            this.lblTelefono.TabIndex = 7;
            this.lblTelefono.Text = "TELÉFONO:";
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(337, 114);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(186, 20);
            this.tbTelefono.TabIndex = 8;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(247, 160);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(29, 13);
            this.lblDNI.TabIndex = 9;
            this.lblDNI.Text = "DNI:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(247, 192);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(69, 13);
            this.lblDireccion.TabIndex = 10;
            this.lblDireccion.Text = "DIRECCIÓN:";
            this.lblDireccion.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblCuentaCorriente
            // 
            this.lblCuentaCorriente.AutoSize = true;
            this.lblCuentaCorriente.Location = new System.Drawing.Point(211, 216);
            this.lblCuentaCorriente.Name = "lblCuentaCorriente";
            this.lblCuentaCorriente.Size = new System.Drawing.Size(120, 13);
            this.lblCuentaCorriente.TabIndex = 11;
            this.lblCuentaCorriente.Text = "CUENTA CORRIENTE:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(247, 248);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 13);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "EMAIL:";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(247, 278);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(84, 13);
            this.lblContraseña.TabIndex = 13;
            this.lblContraseña.Text = "CONTRASEÑA:";
            // 
            // lblRepiteContraseña
            // 
            this.lblRepiteContraseña.AutoSize = true;
            this.lblRepiteContraseña.Location = new System.Drawing.Point(189, 302);
            this.lblRepiteContraseña.Name = "lblRepiteContraseña";
            this.lblRepiteContraseña.Size = new System.Drawing.Size(142, 13);
            this.lblRepiteContraseña.TabIndex = 14;
            this.lblRepiteContraseña.Text = "REPITE LA CONTRASEÑA:";
            // 
            // tbDNI
            // 
            this.tbDNI.Location = new System.Drawing.Point(337, 153);
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(186, 20);
            this.tbDNI.TabIndex = 15;
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(337, 185);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(186, 20);
            this.tbDireccion.TabIndex = 16;
            // 
            // tbCuentaCorriente
            // 
            this.tbCuentaCorriente.Location = new System.Drawing.Point(337, 211);
            this.tbCuentaCorriente.Name = "tbCuentaCorriente";
            this.tbCuentaCorriente.Size = new System.Drawing.Size(186, 20);
            this.tbCuentaCorriente.TabIndex = 17;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(337, 241);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(186, 20);
            this.tbEmail.TabIndex = 18;
            // 
            // tbContraseña
            // 
            this.tbContraseña.Location = new System.Drawing.Point(337, 271);
            this.tbContraseña.Name = "tbContraseña";
            this.tbContraseña.Size = new System.Drawing.Size(186, 20);
            this.tbContraseña.TabIndex = 19;
            // 
            // tbRepiteContraseña
            // 
            this.tbRepiteContraseña.Location = new System.Drawing.Point(337, 297);
            this.tbRepiteContraseña.Name = "tbRepiteContraseña";
            this.tbRepiteContraseña.Size = new System.Drawing.Size(186, 20);
            this.tbRepiteContraseña.TabIndex = 20;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbRepiteContraseña);
            this.Controls.Add(this.tbContraseña);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbCuentaCorriente);
            this.Controls.Add(this.tbDireccion);
            this.Controls.Add(this.tbDNI);
            this.Controls.Add(this.lblRepiteContraseña);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblCuentaCorriente);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.tbTelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.tbApellidos);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnRegister);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbApellidos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblCuentaCorriente;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblRepiteContraseña;
        private System.Windows.Forms.TextBox tbDNI;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.TextBox tbCuentaCorriente;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbContraseña;
        private System.Windows.Forms.TextBox tbRepiteContraseña;
    }
}