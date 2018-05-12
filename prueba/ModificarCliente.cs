using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prueba;
using Negocio;
using Entidad;
namespace presentacion
{
    public partial class ModificarCliente : Form
    {
        public ModificarCliente()
        {
            InitializeComponent();
        }
        ClienteNegocio clienteNegocio = new ClienteNegocio();
        

        private void btAtras_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.Show();
            this.Dispose();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            Cliente cliente= clienteNegocio.GetCliente(MTBCedula.Text);
            if (cliente == null)
            {
                lbMensaje.Text = "No se encontro el cliente";
            }
            else {
                lbMensaje.Text = "";
                TBNombre.Text = cliente.Nombre;
                TBApellido.Text = cliente.Apellido;
                TBEmail.Text = cliente.CorreoElectronico;
                MTBTelefono.Text = ""+cliente.Telefono;
            }
            


        }

        private void BInsertar_Click(object sender, EventArgs e)
        {

        }
    }
}
