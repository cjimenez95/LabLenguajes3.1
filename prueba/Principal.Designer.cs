﻿namespace prueba
{
    partial class Principal
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
            this.btAddClientes = new System.Windows.Forms.Button();
            this.btListaClientes = new System.Windows.Forms.Button();
            this.btBuscarCliente = new System.Windows.Forms.Button();
            this.btIngresarProducto = new System.Windows.Forms.Button();
            this.btListaProductos = new System.Windows.Forms.Button();
            this.btModificarCliente = new System.Windows.Forms.Button();
            this.btFactura = new System.Windows.Forms.Button();
            this.BBuscarProducto = new System.Windows.Forms.Button();
            this.BModificarProducto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btAddClientes
            // 
            this.btAddClientes.Location = new System.Drawing.Point(34, 26);
            this.btAddClientes.Name = "btAddClientes";
            this.btAddClientes.Size = new System.Drawing.Size(109, 23);
            this.btAddClientes.TabIndex = 0;
            this.btAddClientes.Text = "Ingresar Clientes";
            this.btAddClientes.UseVisualStyleBackColor = true;
            this.btAddClientes.Click += new System.EventHandler(this.button1_Click);
            // 
            // btListaClientes
            // 
            this.btListaClientes.Location = new System.Drawing.Point(34, 56);
            this.btListaClientes.Name = "btListaClientes";
            this.btListaClientes.Size = new System.Drawing.Size(109, 23);
            this.btListaClientes.TabIndex = 1;
            this.btListaClientes.Text = "Ver Clientes";
            this.btListaClientes.UseVisualStyleBackColor = true;
            this.btListaClientes.Click += new System.EventHandler(this.button2_Click);
            // 
            // btBuscarCliente
            // 
            this.btBuscarCliente.Location = new System.Drawing.Point(34, 86);
            this.btBuscarCliente.Name = "btBuscarCliente";
            this.btBuscarCliente.Size = new System.Drawing.Size(109, 23);
            this.btBuscarCliente.TabIndex = 2;
            this.btBuscarCliente.Text = "Buscar Clientes";
            this.btBuscarCliente.UseVisualStyleBackColor = true;
            this.btBuscarCliente.Click += new System.EventHandler(this.button3_Click);
            // 
            // btIngresarProducto
            // 
            this.btIngresarProducto.Location = new System.Drawing.Point(185, 26);
            this.btIngresarProducto.Name = "btIngresarProducto";
            this.btIngresarProducto.Size = new System.Drawing.Size(105, 23);
            this.btIngresarProducto.TabIndex = 3;
            this.btIngresarProducto.Text = "Ingresar Producto";
            this.btIngresarProducto.UseVisualStyleBackColor = true;
            this.btIngresarProducto.Click += new System.EventHandler(this.btIngresarProducto_Click);
            // 
            // btListaProductos
            // 
            this.btListaProductos.Location = new System.Drawing.Point(185, 56);
            this.btListaProductos.Name = "btListaProductos";
            this.btListaProductos.Size = new System.Drawing.Size(105, 23);
            this.btListaProductos.TabIndex = 4;
            this.btListaProductos.Text = "ListaProductos";
            this.btListaProductos.UseVisualStyleBackColor = true;
            this.btListaProductos.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btModificarCliente
            // 
            this.btModificarCliente.Location = new System.Drawing.Point(34, 116);
            this.btModificarCliente.Name = "btModificarCliente";
            this.btModificarCliente.Size = new System.Drawing.Size(109, 23);
            this.btModificarCliente.TabIndex = 5;
            this.btModificarCliente.Text = "Modificar Cliente";
            this.btModificarCliente.UseVisualStyleBackColor = true;
            this.btModificarCliente.Click += new System.EventHandler(this.btModificarCliente_Click);
            // 
            // btFactura
            // 
            this.btFactura.Location = new System.Drawing.Point(338, 25);
            this.btFactura.Name = "btFactura";
            this.btFactura.Size = new System.Drawing.Size(92, 23);
            this.btFactura.TabIndex = 6;
            this.btFactura.Text = "Crear factura";
            this.btFactura.UseVisualStyleBackColor = true;
            this.btFactura.Click += new System.EventHandler(this.btFactura_Click);
            // 
            // BBuscarProducto
            // 
            this.BBuscarProducto.Location = new System.Drawing.Point(185, 85);
            this.BBuscarProducto.Name = "BBuscarProducto";
            this.BBuscarProducto.Size = new System.Drawing.Size(105, 23);
            this.BBuscarProducto.TabIndex = 7;
            this.BBuscarProducto.Text = "Buscar Productos";
            this.BBuscarProducto.UseVisualStyleBackColor = true;
            this.BBuscarProducto.Click += new System.EventHandler(this.BBuscarProducto_Click);
            // 
            // BModificarProducto
            // 
            this.BModificarProducto.Location = new System.Drawing.Point(185, 114);
            this.BModificarProducto.Name = "BModificarProducto";
            this.BModificarProducto.Size = new System.Drawing.Size(115, 23);
            this.BModificarProducto.TabIndex = 8;
            this.BModificarProducto.Text = "Modificar Productos";
            this.BModificarProducto.UseVisualStyleBackColor = true;
            this.BModificarProducto.Click += new System.EventHandler(this.BModificarProducto_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 208);
            this.Controls.Add(this.BModificarProducto);
            this.Controls.Add(this.BBuscarProducto);
            this.Controls.Add(this.btFactura);
            this.Controls.Add(this.btModificarCliente);
            this.Controls.Add(this.btListaProductos);
            this.Controls.Add(this.btIngresarProducto);
            this.Controls.Add(this.btBuscarCliente);
            this.Controls.Add(this.btListaClientes);
            this.Controls.Add(this.btAddClientes);
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAddClientes;
        private System.Windows.Forms.Button btListaClientes;
        private System.Windows.Forms.Button btBuscarCliente;
        private System.Windows.Forms.Button btIngresarProducto;
        private System.Windows.Forms.Button btListaProductos;
        private System.Windows.Forms.Button btModificarCliente;
        private System.Windows.Forms.Button btFactura;
        private System.Windows.Forms.Button BBuscarProducto;
        private System.Windows.Forms.Button BModificarProducto;
    }
}