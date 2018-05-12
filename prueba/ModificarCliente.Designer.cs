namespace presentacion
{
    partial class ModificarCliente
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
            this.MTBCedula = new System.Windows.Forms.MaskedTextBox();
            this.MTBTelefono = new System.Windows.Forms.MaskedTextBox();
            this.TBEmail = new System.Windows.Forms.TextBox();
            this.TBApellido = new System.Windows.Forms.TextBox();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.LTelefono = new System.Windows.Forms.Label();
            this.LEmail = new System.Windows.Forms.Label();
            this.LCedula = new System.Windows.Forms.Label();
            this.LApellido = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.BInsertar = new System.Windows.Forms.Button();
            this.btAtras = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.lbMensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MTBCedula
            // 
            this.MTBCedula.Location = new System.Drawing.Point(119, 31);
            this.MTBCedula.Mask = "000000000";
            this.MTBCedula.Name = "MTBCedula";
            this.MTBCedula.Size = new System.Drawing.Size(365, 20);
            this.MTBCedula.TabIndex = 25;
            // 
            // MTBTelefono
            // 
            this.MTBTelefono.Location = new System.Drawing.Point(120, 172);
            this.MTBTelefono.Mask = "(999)000-00000";
            this.MTBTelefono.Name = "MTBTelefono";
            this.MTBTelefono.Size = new System.Drawing.Size(365, 20);
            this.MTBTelefono.TabIndex = 24;
            // 
            // TBEmail
            // 
            this.TBEmail.Location = new System.Drawing.Point(120, 132);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.Size = new System.Drawing.Size(365, 20);
            this.TBEmail.TabIndex = 23;
            // 
            // TBApellido
            // 
            this.TBApellido.Location = new System.Drawing.Point(119, 105);
            this.TBApellido.Name = "TBApellido";
            this.TBApellido.Size = new System.Drawing.Size(365, 20);
            this.TBApellido.TabIndex = 22;
            // 
            // TBNombre
            // 
            this.TBNombre.Location = new System.Drawing.Point(119, 65);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(365, 20);
            this.TBNombre.TabIndex = 21;
            // 
            // LTelefono
            // 
            this.LTelefono.AutoSize = true;
            this.LTelefono.Location = new System.Drawing.Point(34, 179);
            this.LTelefono.Name = "LTelefono";
            this.LTelefono.Size = new System.Drawing.Size(49, 13);
            this.LTelefono.TabIndex = 20;
            this.LTelefono.Text = "Telefono";
            // 
            // LEmail
            // 
            this.LEmail.AutoSize = true;
            this.LEmail.Location = new System.Drawing.Point(34, 140);
            this.LEmail.Name = "LEmail";
            this.LEmail.Size = new System.Drawing.Size(32, 13);
            this.LEmail.TabIndex = 19;
            this.LEmail.Text = "Email";
            // 
            // LCedula
            // 
            this.LCedula.AutoSize = true;
            this.LCedula.Location = new System.Drawing.Point(30, 34);
            this.LCedula.Name = "LCedula";
            this.LCedula.Size = new System.Drawing.Size(40, 13);
            this.LCedula.TabIndex = 18;
            this.LCedula.Text = "Cedula";
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Location = new System.Drawing.Point(33, 108);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(44, 13);
            this.LApellido.TabIndex = 17;
            this.LApellido.Text = "Apellido";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Location = new System.Drawing.Point(30, 65);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(44, 13);
            this.LNombre.TabIndex = 16;
            this.LNombre.Text = "Nombre";
            // 
            // BInsertar
            // 
            this.BInsertar.Location = new System.Drawing.Point(410, 198);
            this.BInsertar.Name = "BInsertar";
            this.BInsertar.Size = new System.Drawing.Size(75, 23);
            this.BInsertar.TabIndex = 15;
            this.BInsertar.Text = "Guardar";
            this.BInsertar.UseVisualStyleBackColor = true;
            this.BInsertar.Click += new System.EventHandler(this.BInsertar_Click);
            // 
            // btAtras
            // 
            this.btAtras.Location = new System.Drawing.Point(568, 198);
            this.btAtras.Name = "btAtras";
            this.btAtras.Size = new System.Drawing.Size(39, 23);
            this.btAtras.TabIndex = 26;
            this.btAtras.Text = "Atras";
            this.btAtras.UseVisualStyleBackColor = true;
            this.btAtras.Click += new System.EventHandler(this.btAtras_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(490, 29);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 23);
            this.btBuscar.TabIndex = 27;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // lbMensaje
            // 
            this.lbMensaje.AutoSize = true;
            this.lbMensaje.Location = new System.Drawing.Point(117, 208);
            this.lbMensaje.Name = "lbMensaje";
            this.lbMensaje.Size = new System.Drawing.Size(0, 13);
            this.lbMensaje.TabIndex = 28;
            // 
            // ModificarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 450);
            this.Controls.Add(this.lbMensaje);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.btAtras);
            this.Controls.Add(this.MTBCedula);
            this.Controls.Add(this.MTBTelefono);
            this.Controls.Add(this.TBEmail);
            this.Controls.Add(this.TBApellido);
            this.Controls.Add(this.TBNombre);
            this.Controls.Add(this.LTelefono);
            this.Controls.Add(this.LEmail);
            this.Controls.Add(this.LCedula);
            this.Controls.Add(this.LApellido);
            this.Controls.Add(this.LNombre);
            this.Controls.Add(this.BInsertar);
            this.Name = "ModificarCliente";
            this.Text = "MoficarCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox MTBCedula;
        private System.Windows.Forms.MaskedTextBox MTBTelefono;
        private System.Windows.Forms.TextBox TBEmail;
        private System.Windows.Forms.TextBox TBApellido;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.Label LTelefono;
        private System.Windows.Forms.Label LEmail;
        private System.Windows.Forms.Label LCedula;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Button BInsertar;
        private System.Windows.Forms.Button btAtras;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Label lbMensaje;
    }
}