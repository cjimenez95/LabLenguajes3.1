using System;
using System.Windows.Forms;
using Entidad;
using Negocio;
using prueba;

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
            FacturaNegocio facturaNegocio = new FacturaNegocio();
            LineaFacturaNegocio lineaFacturaNegocio = new LineaFacturaNegocio();
            Cliente cliente = clienteNegocio.GetCliente(txtCedula.Text);
      
            decimal tempTotal = 0;

            dgvCliente.Rows.Add(cliente.Cedula,cliente.Nombre,cliente.Apellido,cliente.CorreoElectronico,cliente.Telefono);

            foreach (var item in facturaNegocio.getFacturasCliente(txtCedula.Text,dateInicio.Value,dateFinal.Value))
            {
                decimal dbTotal = lineaFacturaNegocio.totalFactura(item.NumFactura);
                
                dgvFacturas.Rows.Add(item.NumFactura,item.FechaHora,dbTotal);
                tempTotal += dbTotal;    
            }
            lbTotal.Text += tempTotal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbCliente.Text = "Cliente " + clienteNegocio.GetCliente(txtCedula.Text).Nombre+" eliminado";
           clienteNegocio.eliminarCliente(txtCedula.Text);
        }

        private void BuscarCliente_Load(object sender, EventArgs e)
        {

        }

        private void btAtras_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.Show();
            this.Close();
        }
    }
}
