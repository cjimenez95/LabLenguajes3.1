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
    public partial class BuscarCliente : Form
    {
        ClienteNegocio clienteNegocio = new ClienteNegocio();
        public BuscarCliente()
        {
            InitializeComponent();

        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
           lbCliente.Text= clienteNegocio.GetCliente(txtCedula.Text).Nombre;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbCliente.Text = "Cliente " + clienteNegocio.GetCliente(txtCedula.Text).Nombre+" eliminado";
           clienteNegocio.eliminarCliente(txtCedula.Text);
        }

        private void BuscarCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
