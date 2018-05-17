using System;
using System.Windows.Forms;
using Negocio;
using prueba;

namespace presentacion
{
    public partial class AgregarProducto : Form
    {
        public AgregarProducto()
        {
            InitializeComponent();
        }

        private void AgregarProducto_Load(object sender, EventArgs e)
        {

        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            try { 
        ProductoNegocio productoNegocio = new ProductoNegocio();
            productoNegocio.addProducto(txtCodigo.Text,txtDescripcion.Text, txtPrecioVenta.Text, txtCantidad.Text);
            }
            catch (Exception em)
            {
                MessageBox.Show("" + em.Message);
            }
        }

        private void btAtras_Click(object sender, EventArgs e)
        {   
            Principal principal = new Principal();
            principal.Show();
            this.Hide();
        }
    }
}
