namespace presentacion
{
    partial class BuscarEliminarProducto
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
            this.BBuscarProducto = new System.Windows.Forms.Button();
            this.BEliminarProducto = new System.Windows.Forms.Button();
            this.TBProductoBuscar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BBuscarProducto
            // 
            this.BBuscarProducto.Location = new System.Drawing.Point(182, 39);
            this.BBuscarProducto.Name = "BBuscarProducto";
            this.BBuscarProducto.Size = new System.Drawing.Size(75, 23);
            this.BBuscarProducto.TabIndex = 0;
            this.BBuscarProducto.Text = "Buscar";
            this.BBuscarProducto.UseVisualStyleBackColor = true;
            // 
            // BEliminarProducto
            // 
            this.BEliminarProducto.Location = new System.Drawing.Point(263, 39);
            this.BEliminarProducto.Name = "BEliminarProducto";
            this.BEliminarProducto.Size = new System.Drawing.Size(75, 23);
            this.BEliminarProducto.TabIndex = 1;
            this.BEliminarProducto.Text = "Eliminar";
            this.BEliminarProducto.UseVisualStyleBackColor = true;
            this.BEliminarProducto.Click += new System.EventHandler(this.button2_Click);
            // 
            // TBProductoBuscar
            // 
            this.TBProductoBuscar.Location = new System.Drawing.Point(13, 13);
            this.TBProductoBuscar.Name = "TBProductoBuscar";
            this.TBProductoBuscar.Size = new System.Drawing.Size(176, 20);
            this.TBProductoBuscar.TabIndex = 2;
            // 
            // BuscarEliminarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 134);
            this.Controls.Add(this.TBProductoBuscar);
            this.Controls.Add(this.BEliminarProducto);
            this.Controls.Add(this.BBuscarProducto);
            this.Name = "BuscarEliminarProducto";
            this.Text = "BuscarEliminarProducto";
            this.Load += new System.EventHandler(this.BuscarEliminarProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BBuscarProducto;
        private System.Windows.Forms.Button BEliminarProducto;
        private System.Windows.Forms.TextBox TBProductoBuscar;
    }
}