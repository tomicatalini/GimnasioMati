namespace GymMati.VentanasNuevas.ProductoIU
{
    partial class ModPreciosProductosUI
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cbxFiltro = new System.Windows.Forms.ComboBox();
            this.listaProductos = new System.Windows.Forms.DataGridView();
            this.codProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contenidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modPrecio = new System.Windows.Forms.DataGridViewButtonColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodyTipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._DataLayer_DataBase_GymMatiContextDataSet3 = new GymMati._DataLayer_DataBase_GymMatiContextDataSet3();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.prodyTipTableAdapter = new GymMati._DataLayer_DataBase_GymMatiContextDataSet3TableAdapters.ProdyTipTableAdapter();
            this.lblPrueba = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodyTipBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._DataLayer_DataBase_GymMatiContextDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtrar por";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(267, 30);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(150, 20);
            this.txtBuscar.TabIndex = 1;
            // 
            // cbxFiltro
            // 
            this.cbxFiltro.FormattingEnabled = true;
            this.cbxFiltro.Location = new System.Drawing.Point(129, 29);
            this.cbxFiltro.Name = "cbxFiltro";
            this.cbxFiltro.Size = new System.Drawing.Size(121, 21);
            this.cbxFiltro.TabIndex = 2;
            // 
            // listaProductos
            // 
            this.listaProductos.AllowUserToAddRows = false;
            this.listaProductos.AllowUserToDeleteRows = false;
            this.listaProductos.AutoGenerateColumns = false;
            this.listaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codProductoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.tipoProductoDataGridViewTextBoxColumn,
            this.contenidoDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.modPrecio,
            this.descripcionDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn});
            this.listaProductos.DataSource = this.prodyTipBindingSource;
            this.listaProductos.Location = new System.Drawing.Point(24, 73);
            this.listaProductos.Name = "listaProductos";
            this.listaProductos.RowHeadersVisible = false;
            this.listaProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaProductos.Size = new System.Drawing.Size(585, 303);
            this.listaProductos.TabIndex = 3;
            this.listaProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaProductos_CellContentClick);
            this.listaProductos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaProductos_CellValueChanged);
            // 
            // codProductoDataGridViewTextBoxColumn
            // 
            this.codProductoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.codProductoDataGridViewTextBoxColumn.DataPropertyName = "codProducto";
            this.codProductoDataGridViewTextBoxColumn.Frozen = true;
            this.codProductoDataGridViewTextBoxColumn.HeaderText = "Nro";
            this.codProductoDataGridViewTextBoxColumn.Name = "codProductoDataGridViewTextBoxColumn";
            this.codProductoDataGridViewTextBoxColumn.Width = 49;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.Frozen = true;
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.Width = 67;
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "marca";
            this.marcaDataGridViewTextBoxColumn.Frozen = true;
            this.marcaDataGridViewTextBoxColumn.HeaderText = "marca";
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            this.marcaDataGridViewTextBoxColumn.Width = 61;
            // 
            // tipoProductoDataGridViewTextBoxColumn
            // 
            this.tipoProductoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tipoProductoDataGridViewTextBoxColumn.DataPropertyName = "tipoProducto";
            this.tipoProductoDataGridViewTextBoxColumn.Frozen = true;
            this.tipoProductoDataGridViewTextBoxColumn.HeaderText = "tipoProducto";
            this.tipoProductoDataGridViewTextBoxColumn.Name = "tipoProductoDataGridViewTextBoxColumn";
            this.tipoProductoDataGridViewTextBoxColumn.Width = 92;
            // 
            // contenidoDataGridViewTextBoxColumn
            // 
            this.contenidoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.contenidoDataGridViewTextBoxColumn.DataPropertyName = "contenido";
            this.contenidoDataGridViewTextBoxColumn.Frozen = true;
            this.contenidoDataGridViewTextBoxColumn.HeaderText = "contenido";
            this.contenidoDataGridViewTextBoxColumn.Name = "contenidoDataGridViewTextBoxColumn";
            this.contenidoDataGridViewTextBoxColumn.Width = 79;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "precio";
            this.precioDataGridViewTextBoxColumn.Frozen = true;
            this.precioDataGridViewTextBoxColumn.HeaderText = "precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.Width = 61;
            // 
            // modPrecio
            // 
            this.modPrecio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.modPrecio.Frozen = true;
            this.modPrecio.HeaderText = "Mod. Precio";
            this.modPrecio.Name = "modPrecio";
            this.modPrecio.Text = "Cambiar";
            this.modPrecio.Width = 70;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.Frozen = true;
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.Visible = false;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "stock";
            this.stockDataGridViewTextBoxColumn.Frozen = true;
            this.stockDataGridViewTextBoxColumn.HeaderText = "stock";
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            this.stockDataGridViewTextBoxColumn.Visible = false;
            // 
            // prodyTipBindingSource
            // 
            this.prodyTipBindingSource.DataMember = "ProdyTip";
            this.prodyTipBindingSource.DataSource = this._DataLayer_DataBase_GymMatiContextDataSet3;
            // 
            // _DataLayer_DataBase_GymMatiContextDataSet3
            // 
            this._DataLayer_DataBase_GymMatiContextDataSet3.DataSetName = "_DataLayer_DataBase_GymMatiContextDataSet3";
            this._DataLayer_DataBase_GymMatiContextDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(534, 482);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CerrarVentana);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(453, 482);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Aceptar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Aceptar);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(24, 397);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(423, 108);
            this.txtDescripcion.TabIndex = 6;
            this.txtDescripcion.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Descripcion ( prod. seleccionado)";
            // 
            // prodyTipTableAdapter
            // 
            this.prodyTipTableAdapter.ClearBeforeFill = true;
            // 
            // lblPrueba
            // 
            this.lblPrueba.AutoSize = true;
            this.lblPrueba.Location = new System.Drawing.Point(531, 29);
            this.lblPrueba.Name = "lblPrueba";
            this.lblPrueba.Size = new System.Drawing.Size(19, 13);
            this.lblPrueba.TabIndex = 8;
            this.lblPrueba.Text = "no";
            this.lblPrueba.Visible = false;
            // 
            // ModPreciosProductosUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 517);
            this.Controls.Add(this.lblPrueba);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listaProductos);
            this.Controls.Add(this.cbxFiltro);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Name = "ModPreciosProductosUI";
            this.Text = "Gym Rocamora - Inventario Productos";
            this.Load += new System.EventHandler(this.ModPreciosProductosUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodyTipBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._DataLayer_DataBase_GymMatiContextDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cbxFiltro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox txtDescripcion;
        private System.Windows.Forms.Label label2;
        private _DataLayer_DataBase_GymMatiContextDataSet3 _DataLayer_DataBase_GymMatiContextDataSet3;
        private System.Windows.Forms.BindingSource prodyTipBindingSource;
        private _DataLayer_DataBase_GymMatiContextDataSet3TableAdapters.ProdyTipTableAdapter prodyTipTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contenidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn modPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        protected System.Windows.Forms.DataGridView listaProductos;
        private System.Windows.Forms.Label lblPrueba;
    }
}