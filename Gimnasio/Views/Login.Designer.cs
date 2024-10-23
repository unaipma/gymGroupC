namespace Gimnasio.Views
{
    partial class Login
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
            this.lGmail = new System.Windows.Forms.Label();
            this.lContra = new System.Windows.Forms.Label();
            this.bBorrar = new System.Windows.Forms.Button();
            this.bAceptar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lGmail
            // 
            this.lGmail.AutoSize = true;
            this.lGmail.Location = new System.Drawing.Point(41, 235);
            this.lGmail.Name = "lGmail";
            this.lGmail.Size = new System.Drawing.Size(40, 13);
            this.lGmail.TabIndex = 0;
            this.lGmail.Text = "GMAIL";
            // 
            // lContra
            // 
            this.lContra.AutoSize = true;
            this.lContra.Location = new System.Drawing.Point(23, 284);
            this.lContra.Name = "lContra";
            this.lContra.Size = new System.Drawing.Size(81, 13);
            this.lContra.TabIndex = 1;
            this.lContra.Text = "CONTRASEÑA";
            // 
            // bBorrar
            // 
            this.bBorrar.Location = new System.Drawing.Point(64, 367);
            this.bBorrar.Name = "bBorrar";
            this.bBorrar.Size = new System.Drawing.Size(75, 23);
            this.bBorrar.TabIndex = 2;
            this.bBorrar.Text = "Borrar";
            this.bBorrar.UseVisualStyleBackColor = true;
            this.bBorrar.Click += new System.EventHandler(this.bBorrar_Click);
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(206, 367);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 3;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 232);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(110, 281);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(171, 20);
            this.textBox2.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Gimnasio.Properties.Resources.logoGym;
            this.pictureBox2.Location = new System.Drawing.Point(64, 50);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(204, 136);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // bAtras
            // 
            this.bAtras.Location = new System.Drawing.Point(-1, -1);
            this.bAtras.Name = "bAtras";
            this.bAtras.Size = new System.Drawing.Size(75, 23);
            this.bAtras.TabIndex = 7;
            this.bAtras.Text = "Atras";
            this.bAtras.UseVisualStyleBackColor = true;
            this.bAtras.Click += new System.EventHandler(this.bAtras_Click);
            // 
            // Login
            // 
            this.ClientSize = new System.Drawing.Size(320, 459);
            this.Controls.Add(this.bAtras);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.bBorrar);
            this.Controls.Add(this.lContra);
            this.Controls.Add(this.lGmail);
            this.Name = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lGmail;
        private System.Windows.Forms.Label lContra;
        private System.Windows.Forms.Button bBorrar;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button bAtras;
    }
}