namespace prueba
{
    partial class AgregarCliente
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
            this.BInsertar = new System.Windows.Forms.Button();
            this.LNombre = new System.Windows.Forms.Label();
            this.LApellido = new System.Windows.Forms.Label();
            this.LCedula = new System.Windows.Forms.Label();
            this.LEmail = new System.Windows.Forms.Label();
            this.LTelefono = new System.Windows.Forms.Label();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.TBApellido = new System.Windows.Forms.TextBox();
            this.TBEmail = new System.Windows.Forms.TextBox();
            this.MTBTelefono = new System.Windows.Forms.MaskedTextBox();
            this.MTBCedula = new System.Windows.Forms.MaskedTextBox();
            this.btAtras = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BInsertar
            // 
            this.BInsertar.Location = new System.Drawing.Point(270, 217);
            this.BInsertar.Name = "BInsertar";
            this.BInsertar.Size = new System.Drawing.Size(75, 23);
            this.BInsertar.TabIndex = 2;
            this.BInsertar.Text = "Insertar";
            this.BInsertar.UseVisualStyleBackColor = true;
            this.BInsertar.Click += new System.EventHandler(this.button1_Click);
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Location = new System.Drawing.Point(31, 44);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(44, 13);
            this.LNombre.TabIndex = 3;
            this.LNombre.Text = "Nombre";
            this.LNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Location = new System.Drawing.Point(34, 87);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(44, 13);
            this.LApellido.TabIndex = 4;
            this.LApellido.Text = "Apellido";
            // 
            // LCedula
            // 
            this.LCedula.AutoSize = true;
            this.LCedula.Location = new System.Drawing.Point(34, 123);
            this.LCedula.Name = "LCedula";
            this.LCedula.Size = new System.Drawing.Size(40, 13);
            this.LCedula.TabIndex = 5;
            this.LCedula.Text = "Cedula";
            // 
            // LEmail
            // 
            this.LEmail.AutoSize = true;
            this.LEmail.Location = new System.Drawing.Point(34, 159);
            this.LEmail.Name = "LEmail";
            this.LEmail.Size = new System.Drawing.Size(32, 13);
            this.LEmail.TabIndex = 6;
            this.LEmail.Text = "Email";
            // 
            // LTelefono
            // 
            this.LTelefono.AutoSize = true;
            this.LTelefono.Location = new System.Drawing.Point(34, 198);
            this.LTelefono.Name = "LTelefono";
            this.LTelefono.Size = new System.Drawing.Size(49, 13);
            this.LTelefono.TabIndex = 7;
            this.LTelefono.Text = "Telefono";
            // 
            // TBNombre
            // 
            this.TBNombre.Location = new System.Drawing.Point(120, 44);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(225, 20);
            this.TBNombre.TabIndex = 8;
            // 
            // TBApellido
            // 
            this.TBApellido.Location = new System.Drawing.Point(120, 84);
            this.TBApellido.Name = "TBApellido";
            this.TBApellido.Size = new System.Drawing.Size(225, 20);
            this.TBApellido.TabIndex = 9;
            // 
            // TBEmail
            // 
            this.TBEmail.Location = new System.Drawing.Point(120, 151);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.Size = new System.Drawing.Size(225, 20);
            this.TBEmail.TabIndex = 11;
            // 
            // MTBTelefono
            // 
            this.MTBTelefono.Location = new System.Drawing.Point(120, 191);
            this.MTBTelefono.Mask = "(999)000-00000";
            this.MTBTelefono.Name = "MTBTelefono";
            this.MTBTelefono.Size = new System.Drawing.Size(225, 20);
            this.MTBTelefono.TabIndex = 13;
            // 
            // MTBCedula
            // 
            this.MTBCedula.Location = new System.Drawing.Point(120, 116);
            this.MTBCedula.Mask = "0000000";
            this.MTBCedula.Name = "MTBCedula";
            this.MTBCedula.Size = new System.Drawing.Size(225, 20);
            this.MTBCedula.TabIndex = 14;
            // 
            // btAtras
            // 
            this.btAtras.Location = new System.Drawing.Point(12, 12);
            this.btAtras.Name = "btAtras";
            this.btAtras.Size = new System.Drawing.Size(39, 23);
            this.btAtras.TabIndex = 15;
            this.btAtras.Text = "Atras";
            this.btAtras.UseVisualStyleBackColor = true;
            this.btAtras.Click += new System.EventHandler(this.btAtras_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ingresar cliente";
            // 
            // AgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 252);
            this.Controls.Add(this.label1);
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
            this.Name = "AgregarCliente";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BInsertar;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.Label LCedula;
        private System.Windows.Forms.Label LEmail;
        private System.Windows.Forms.Label LTelefono;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.TextBox TBApellido;
        private System.Windows.Forms.TextBox TBEmail;
        private System.Windows.Forms.MaskedTextBox MTBTelefono;
        private System.Windows.Forms.MaskedTextBox MTBCedula;
        private System.Windows.Forms.Button btAtras;
        private System.Windows.Forms.Label label1;
    }
}

