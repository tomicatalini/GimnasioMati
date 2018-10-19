namespace GymMati.VentanasNuevas.SocioUI
{
    partial class VerSocioUI
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
            this.label10 = new System.Windows.Forms.Label();
            this.btnBajaSocio = new System.Windows.Forms.Button();
            this.lblBajaSocio = new System.Windows.Forms.Label();
            this.btnModificar = new GymMati.VentanasNuevas.ControlesPersonalizados.ButtonPressed();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label10);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Enabled = false;
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Enabled = false;
            // 
            // dateFechaNacimiento
            // 
            this.dateFechaNacimiento.Enabled = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            // 
            // txtApellido
            // 
            this.txtApellido.Enabled = false;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Enabled = false;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Enabled = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Text = "Aceptar";
            this.btnCerrar.Click += new System.EventHandler(this.AceptarVerSocioEvent);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(282, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(326, 28);
            this.label10.TabIndex = 2;
            this.label10.Text = "Ver Socio - Datos del Socio";
            // 
            // btnBajaSocio
            // 
            this.btnBajaSocio.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBajaSocio.Location = new System.Drawing.Point(350, 416);
            this.btnBajaSocio.Name = "btnBajaSocio";
            this.btnBajaSocio.Size = new System.Drawing.Size(74, 52);
            this.btnBajaSocio.TabIndex = 34;
            this.btnBajaSocio.Text = "Dar de Baja Socio";
            this.btnBajaSocio.UseVisualStyleBackColor = true;
            this.btnBajaSocio.Click += new System.EventHandler(this.BajaSocioEvent);
            // 
            // lblBajaSocio
            // 
            this.lblBajaSocio.AutoSize = true;
            this.lblBajaSocio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBajaSocio.ForeColor = System.Drawing.Color.Red;
            this.lblBajaSocio.Location = new System.Drawing.Point(475, 416);
            this.lblBajaSocio.Name = "lblBajaSocio";
            this.lblBajaSocio.Size = new System.Drawing.Size(296, 19);
            this.lblBajaSocio.TabIndex = 35;
            this.lblBajaSocio.Text = "El socio se dió de baja exitosamente";
            this.lblBajaSocio.Visible = false;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(51)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.IsPressed = false;
            this.btnModificar.Location = new System.Drawing.Point(260, 416);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 52);
            this.btnModificar.TabIndex = 36;
            this.btnModificar.Text = "Modificar Socio";
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // VerSocioUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 480);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lblBajaSocio);
            this.Controls.Add(this.btnBajaSocio);
            this.Name = "VerSocioUI";
            this.Text = "VerSocioUI";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.txtBuscarSocio, 0);
            this.Controls.SetChildIndex(this.txtDocumento, 0);
            this.Controls.SetChildIndex(this.txtTelefono, 0);
            this.Controls.SetChildIndex(this.txtApellido, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.dateFechaNacimiento, 0);
            this.Controls.SetChildIndex(this.txtDomicilio, 0);
            this.Controls.SetChildIndex(this.txtCorreo, 0);
            this.Controls.SetChildIndex(this.btnCerrar, 0);
            this.Controls.SetChildIndex(this.btnBajaSocio, 0);
            this.Controls.SetChildIndex(this.lblBajaSocio, 0);
            this.Controls.SetChildIndex(this.btnModificar, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnBajaSocio;
        private System.Windows.Forms.Label lblBajaSocio;
        private ControlesPersonalizados.ButtonPressed btnModificar;
    }
}