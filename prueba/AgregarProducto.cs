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
        ProductoNegocio productoNegocio = new ProductoNegocio();
            productoNegocio.addProducto(txtCodigo.Text,txtDescripcion.Text, txtPrecioVenta.Text, txtCantidad.Text);
        }

        private void btAtras_Click(object sender, EventArgs e)
        {   
            Principal principal = new Principal();
            principal.Show();
            this.Hide();
        }
    }
}
