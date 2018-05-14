namespace presentacion
{
    partial class CrearFactura
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
            this.btBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.lbCliente = new System.Windows.Forms.Label();
            this.txtCodAgregar = new System.Windows.Forms.TextBox();
            this.btAgregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCantidadAgregar = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btModificar = new System.Windows.Forms.Button();
            this.txtCodModificar = new System.Windows.Forms.TextBox();
            this.txtCantidadModificar = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvLineasFactura = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.btAtras = new System.Windows.Forms.Button();
            this.btGuardarFactura = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLineasFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(195, 19);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 23);
            this.btBuscar.TabIndex = 0;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cedula cliente";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(13, 19);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(165, 20);
            this.txtCedula.TabIndex = 2;
            // 
            // lbCliente
            // 
            this.lbCliente.AutoSize = true;
            this.lbCliente.Location = new System.Drawing.Point(13, 46);
            this.lbCliente.Name = "lbCliente";
            this.lbCliente.Size = new System.Drawing.Size(0, 13);
            this.lbCliente.TabIndex = 3;
            // 
            // txtCodAgregar
            // 
            this.txtCodAgregar.Location = new System.Drawing.Point(5, 15);
            this.txtCodAgregar.Name = "txtCodAgregar";
            this.txtCodAgregar.Size = new System.Drawing.Size(108, 20);
            this.txtCodAgregar.TabIndex = 4;
            this.txtCodAgregar.Text = "CodigoProdcuto";
            this.txtCodAgregar.Click += new System.EventHandler(this.txtCodAgregar_TextChanged);
            this.txtCodAgregar.TextChanged += new System.EventHandler(this.txtCodAgregar_TextChanged);
            this.txtCodAgregar.Leave += new System.EventHandler(this.txtCodAgregar_TextChanged);
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(218, 16);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(75, 23);
            this.btAgregar.TabIndex = 5;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbCliente);
            this.groupBox1.Controls.Add(this.txtCedula);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btBuscar);
            this.groupBox1.Location = new System.Drawing.Point(3, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 72);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // txtCantidadAgregar
            // 
            this.txtCantidadAgregar.Location = new System.Drawing.Point(119, 16);
            this.txtCantidadAgregar.Name = "txtCantidadAgregar";
            this.txtCantidadAgregar.Size = new System.Drawing.Size(81, 20);
            this.txtCantidadAgregar.TabIndex = 7;
            this.txtCantidadAgregar.Text = "Cantidad";
            this.txtCantidadAgregar.TextChanged += new System.EventHandler(this.txtCantidadAgregar_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCantidadAgregar);
            this.groupBox2.Controls.Add(this.btAgregar);
            this.groupBox2.Controls.Add(this.txtCodAgregar);
            this.groupBox2.Location = new System.Drawing.Point(3, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 42);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // btModificar
            // 
            this.btModificar.Location = new System.Drawing.Point(218, 14);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(75, 23);
            this.btModificar.TabIndex = 9;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = true;
            // 
            // txtCodModificar
            // 
            this.txtCodModificar.Location = new System.Drawing.Point(5, 17);
            this.txtCodModificar.Name = "txtCodModificar";
            this.txtCodModificar.Size = new System.Drawing.Size(103, 20);
            this.txtCodModificar.TabIndex = 10;
            this.txtCodModificar.Text = "CodigoProducto";
            // 
            // txtCantidadModificar
            // 
            this.txtCantidadModificar.Location = new System.Drawing.Point(114, 17);
            this.txtCantidadModificar.Name = "txtCantidadModificar";
            this.txtCantidadModificar.Size = new System.Drawing.Size(81, 20);
            this.txtCantidadModificar.TabIndex = 11;
            this.txtCantidadModificar.Text = "Cantidad";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtCantidadModificar);
            this.groupBox3.Controls.Add(this.txtCodModificar);
            this.groupBox3.Controls.Add(this.btModificar);
            this.groupBox3.Location = new System.Drawing.Point(3, 133);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(304, 67);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "**Nota: cantidad igual a 0 eliminará el producto";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dgvLineasFactura
            // 
            this.dgvLineasFactura.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvLineasFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLineasFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Cantidad,
            this.Producto,
            this.Precio,
            this.Total});
            this.dgvLineasFactura.Location = new System.Drawing.Point(8, 207);
            this.dgvLineasFactura.Name = "dgvLineasFactura";
            this.dgvLineasFactura.Size = new System.Drawing.Size(542, 150);
            this.dgvLineasFactura.TabIndex = 13;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 65;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.Width = 170;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.Width = 80;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Total: ";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(393, 176);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(25, 13);
            this.lbTotal.TabIndex = 15;
            this.lbTotal.Text = "777";
            // 
            // btAtras
            // 
            this.btAtras.Location = new System.Drawing.Point(353, 26);
            this.btAtras.Name = "btAtras";
            this.btAtras.Size = new System.Drawing.Size(75, 23);
            this.btAtras.TabIndex = 16;
            this.btAtras.Text = "Atras";
            this.btAtras.UseVisualStyleBackColor = true;
            // 
            // btGuardarFactura
            // 
            this.btGuardarFactura.Location = new System.Drawing.Point(456, 25);
            this.btGuardarFactura.Name = "btGuardarFactura";
            this.btGuardarFactura.Size = new System.Drawing.Size(75, 23);
            this.btGuardarFactura.TabIndex = 17;
            this.btGuardarFactura.Text = "Guardar";
            this.btGuardarFactura.UseVisualStyleBackColor = true;
            // 
            // CrearFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 303);
            this.Controls.Add(this.btGuardarFactura);
            this.Controls.Add(this.btAtras);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvLineasFactura);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CrearFactura";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.Factura_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLineasFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label lbCliente;
        private System.Windows.Forms.TextBox txtCodAgregar;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCantidadAgregar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.TextBox txtCodModificar;
        private System.Windows.Forms.TextBox txtCantidadModificar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvLineasFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Button btAtras;
        private System.Windows.Forms.Button btGuardarFactura;
    }
}