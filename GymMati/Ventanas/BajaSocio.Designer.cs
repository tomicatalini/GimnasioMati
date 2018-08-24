namespace GymMati.Ventanas
{
    partial class BajaSocio
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
            this.label9 = new System.Windows.Forms.Label();
            this.btBuscar = new System.Windows.Forms.Button();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nope = new System.Windows.Forms.Label();
            this.baja = new System.Windows.Forms.Label();
            this.btCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 13);
            this.label9.TabIndex = 47;
            this.label9.Text = "Ingresar dni del socio a dar de baja";
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(201, 31);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(61, 20);
            this.btBuscar.TabIndex = 46;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // tbBuscar
            // 
            this.tbBuscar.Location = new System.Drawing.Point(80, 32);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(100, 20);
            this.tbBuscar.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "DNI";
            // 
            // nope
            // 
            this.nope.AutoSize = true;
            this.nope.BackColor = System.Drawing.SystemColors.Control;
            this.nope.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nope.ForeColor = System.Drawing.Color.Red;
            this.nope.Location = new System.Drawing.Point(65, 75);
            this.nope.Name = "nope";
            this.nope.Size = new System.Drawing.Size(197, 20);
            this.nope.TabIndex = 48;
            this.nope.Text = "No se encontro el socio";
            this.nope.Visible = false;
            // 
            // baja
            // 
            this.baja.AutoSize = true;
            this.baja.BackColor = System.Drawing.SystemColors.Control;
            this.baja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baja.ForeColor = System.Drawing.Color.Red;
            this.baja.Location = new System.Drawing.Point(65, 95);
            this.baja.Name = "baja";
            this.baja.Size = new System.Drawing.Size(194, 20);
            this.baja.TabIndex = 49;
            this.baja.Text = "El socio se dio de baja!";
            this.baja.Visible = false;
            // 
            // btCerrar
            // 
            this.btCerrar.Location = new System.Drawing.Point(255, 118);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(75, 23);
            this.btCerrar.TabIndex = 50;
            this.btCerrar.Text = "Cerrar";
            this.btCerrar.UseVisualStyleBackColor = true;
            this.btCerrar.Click += new System.EventHandler(this.btCerrar_Click);
            // 
            // BajaSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 153);
            this.Controls.Add(this.btCerrar);
            this.Controls.Add(this.baja);
            this.Controls.Add(this.nope);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.tbBuscar);
            this.Controls.Add(this.label8);
            this.Name = "BajaSocio";
            this.Text = "BajaSocio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label nope;
        private System.Windows.Forms.Label baja;
        private System.Windows.Forms.Button btCerrar;
    }
}