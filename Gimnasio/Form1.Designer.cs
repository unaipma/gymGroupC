namespace Gimnasio
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pBLogo = new System.Windows.Forms.PictureBox();
            this.bInicioSesion = new System.Windows.Forms.Button();
            this.bRegistrarse = new System.Windows.Forms.Button();
            this.labelNombreGym = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pBLogo
            // 
            this.pBLogo.ErrorImage = null;
            this.pBLogo.Image = global::Gimnasio.Properties.Resources.logoGym;
            this.pBLogo.InitialImage = global::Gimnasio.Properties.Resources.logoGym;
            this.pBLogo.Location = new System.Drawing.Point(110, 30);
            this.pBLogo.Name = "pBLogo";
            this.pBLogo.Size = new System.Drawing.Size(204, 136);
            this.pBLogo.TabIndex = 0;
            this.pBLogo.TabStop = false;
            // 
            // bInicioSesion
            // 
            this.bInicioSesion.Location = new System.Drawing.Point(144, 222);
            this.bInicioSesion.Name = "bInicioSesion";
            this.bInicioSesion.Size = new System.Drawing.Size(133, 23);
            this.bInicioSesion.TabIndex = 1;
            this.bInicioSesion.Text = "Iniciar Sesión";
            this.bInicioSesion.UseVisualStyleBackColor = true;
            this.bInicioSesion.Click += new System.EventHandler(this.bInicioSesion_Click);
            // 
            // bRegistrarse
            // 
            this.bRegistrarse.Location = new System.Drawing.Point(144, 288);
            this.bRegistrarse.Name = "bRegistrarse";
            this.bRegistrarse.Size = new System.Drawing.Size(133, 23);
            this.bRegistrarse.TabIndex = 2;
            this.bRegistrarse.Text = "Registrarse";
            this.bRegistrarse.UseVisualStyleBackColor = true;
            this.bRegistrarse.Click += new System.EventHandler(this.bRegistrarse_Click);
            // 
            // labelNombreGym
            // 
            this.labelNombreGym.AutoSize = true;
            this.labelNombreGym.BackColor = System.Drawing.SystemColors.Highlight;
            this.labelNombreGym.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreGym.Location = new System.Drawing.Point(125, 136);
            this.labelNombreGym.Name = "labelNombreGym";
            this.labelNombreGym.Size = new System.Drawing.Size(174, 30);
            this.labelNombreGym.TabIndex = 3;
            this.labelNombreGym.Text = "GYMSHARK";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 371);
            this.Controls.Add(this.labelNombreGym);
            this.Controls.Add(this.bRegistrarse);
            this.Controls.Add(this.bInicioSesion);
            this.Controls.Add(this.pBLogo);
            this.MaximumSize = new System.Drawing.Size(439, 410);
            this.MinimumSize = new System.Drawing.Size(439, 410);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GYMSHARK";
            ((System.ComponentModel.ISupportInitialize)(this.pBLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBLogo;
        private System.Windows.Forms.Button bInicioSesion;
        private System.Windows.Forms.Button bRegistrarse;
        private System.Windows.Forms.Label labelNombreGym;
    }
}

