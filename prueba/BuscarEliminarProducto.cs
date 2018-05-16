using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
namespace presentacion
{
    public partial class BuscarEliminarProducto : Form
    {
        ProductoFunciones productoFunciones = new ProductoFunciones();
        public BuscarEliminarProducto()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //.Text = productoFunciones.GetCliente(TBProductoBuscar.Text).
            //     lbCliente.Text = clienteNegocio.GetCliente(txtCedula.Text).Nombre;
        }

        private void BuscarEliminarProducto_Load(object sender, EventArgs e)
        {

        }
    }
}
