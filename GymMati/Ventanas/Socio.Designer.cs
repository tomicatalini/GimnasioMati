namespace GymMati.Ventanas
{
    partial class Socio
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
            this.btClose = new System.Windows.Forms.Button();
            this.btVerSocio = new System.Windows.Forms.Button();
            this.btBajaSocio = new System.Windows.Forms.Button();
            this.btModSocio = new System.Windows.Forms.Button();
            this.btAltaSocio = new System.Windows.Forms.Button();
            this.btnBD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(403, 247);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 9;
            this.btClose.Text = "Cerrar";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btVerSocio
            // 
            this.btVerSocio.Location = new System.Drawing.Point(298, 128);
            this.btVerSocio.Name = "btVerSocio";
            this.btVerSocio.Size = new System.Drawing.Size(160, 60);
            this.btVerSocio.TabIndex = 8;
            this.btVerSocio.Text = "Ver Socio";
            this.btVerSocio.UseVisualStyleBackColor = true;
            this.btVerSocio.Click += new System.EventHandler(this.btVerSocio_Click);
            // 
            // btBajaSocio
            // 
            this.btBajaSocio.Location = new System.Drawing.Point(56, 128);
            this.btBajaSocio.Name = "btBajaSocio";
            this.btBajaSocio.Size = new System.Drawing.Size(160, 60);
            this.btBajaSocio.TabIndex = 7;
            this.btBajaSocio.Text = "Baja Socio";
            this.btBajaSocio.UseVisualStyleBackColor = true;
            this.btBajaSocio.Click += new System.EventHandler(this.btBajaSocio_Click);
            // 
            // btModSocio
            // 
            this.btModSocio.Location = new System.Drawing.Point(298, 30);
            this.btModSocio.Name = "btModSocio";
            this.btModSocio.Size = new System.Drawing.Size(160, 60);
            this.btModSocio.TabIndex = 6;
            this.btModSocio.Text = "Modificar Socio";
            this.btModSocio.UseVisualStyleBackColor = true;
            this.btModSocio.Click += new System.EventHandler(this.btModSocio_Click);
            // 
            // btAltaSocio
            // 
            this.btAltaSocio.Location = new System.Drawing.Point(56, 30);
            this.btAltaSocio.Name = "btAltaSocio";
            this.btAltaSocio.Size = new System.Drawing.Size(160, 60);
            this.btAltaSocio.TabIndex = 5;
            this.btAltaSocio.Text = "Alta Socio";
            this.btAltaSocio.UseVisualStyleBackColor = true;
            this.btAltaSocio.Click += new System.EventHandler(this.btAltaSocio_Click);
            // 
            // btnBD
            // 
            this.btnBD.Location = new System.Drawing.Point(298, 247);
            this.btnBD.Name = "btnBD";
            this.btnBD.Size = new System.Drawing.Size(75, 23);
            this.btnBD.TabIndex = 10;
            this.btnBD.Text = "Probar BD";
            this.btnBD.UseVisualStyleBackColor = true;
            this.btnBD.Click += new System.EventHandler(this.button1_Click);
            // 
            // Socio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 290);
            this.Controls.Add(this.btnBD);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btVerSocio);
            this.Controls.Add(this.btBajaSocio);
            this.Controls.Add(this.btModSocio);
            this.Controls.Add(this.btAltaSocio);
            this.Name = "Socio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Socio";
            this.Load += new System.EventHandler(this.Socio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btVerSocio;
        private System.Windows.Forms.Button btBajaSocio;
        private System.Windows.Forms.Button btModSocio;
        private System.Windows.Forms.Button btAltaSocio;
        private System.Windows.Forms.Button btnBD;
    }
}