using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using presentacion;
using Negocio;
using Entidad;

namespace prueba
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            AgregarCliente form1 = new AgregarCliente();
            form1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClienteNegocio clienteNegocio = new ClienteNegocio();
            ListaClientes listaClientes = new ListaClientes();
            listaClientes.Show();
            this.Hide();

            List<Cliente> list = clienteNegocio.GetClientes();
            foreach (var item in list)
            {
                listaClientes.dgvListaClientes.Rows.Add(item.Cedula,item.Nombre, item.Apellido, item.CorreoElectronico,item.Telefono);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BuscarCliente buscarCliente = new BuscarCliente();
            buscarCliente.Show();
            this.Hide();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void btIngresarProducto_Click(object sender, EventArgs e)
        {
            AgregarProducto agregarProducto = new AgregarProducto();
            agregarProducto.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ListaProductos listaProductos = new ListaProductos();
            ProductoNegocio productoNegocio = new ProductoNegocio();
            List<Producto> list = productoNegocio.GetProductos();
            foreach (var item in list)

            {
                listaProductos.dgvProductos.Rows.Add(item.Codigo,item.Producto1,item.Precio,item.Cantidad);
            }           
            listaProductos.Show();
            this.Hide();
        }

        private void btModificarCliente_Click(object sender, EventArgs e)
        {
            ModificarCliente modificarCliente = new ModificarCliente();
            modificarCliente.Show();
            this.Hide();
        }

        private void btFactura_Click(object sender, EventArgs e)
        {
            CrearFactura factura = new CrearFactura();
            factura.Show();
            this.Hide();
        }

        private void BModificarProducto_Click(object sender, EventArgs e)
        {

        }
    }
}
