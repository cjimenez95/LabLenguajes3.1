namespace Aplicacion
{
    partial class ListaClientes
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbListaClientes = new System.Windows.Forms.Label();
            this.btCargarCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clientes:";
            // 
            // lbListaClientes
            // 
            this.lbListaClientes.AutoSize = true;
            this.lbListaClientes.Location = new System.Drawing.Point(15, 38);
            this.lbListaClientes.Name = "lbListaClientes";
            this.lbListaClientes.Size = new System.Drawing.Size(0, 13);
            this.lbListaClientes.TabIndex = 1;
            // 
            // btCargarCliente
            // 
            this.btCargarCliente.Location = new System.Drawing.Point(380, 21);
            this.btCargarCliente.Name = "btCargarCliente";
            this.btCargarCliente.Size = new System.Drawing.Size(100, 23);
            this.btCargarCliente.TabIndex = 2;
            this.btCargarCliente.Text = "Cargar Clientes";
            this.btCargarCliente.UseVisualStyleBackColor = true;
            this.btCargarCliente.Click += new System.EventHandler(this.btCargarCliente_Click);
            // 
            // ListaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 309);
            this.Controls.Add(this.btCargarCliente);
            this.Controls.Add(this.lbListaClientes);
            this.Controls.Add(this.label1);
            this.Name = "ListaClientes";
            this.Text = "ListaClientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbListaClientes;
        private System.Windows.Forms.Button btCargarCliente;
    }
}