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
using Entidad;

namespace presentacion
{
    public partial class CrearFactura : Form
    {
        public CrearFactura()
        {
            InitializeComponent();
        }


        Cliente cliente = new Cliente();
        ProductoNegocio productoNegocio = new ProductoNegocio();
        List<LineaFactura> listaProductos = new List<LineaFactura>();

        private void Factura_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtCodAgregar_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtCantidadAgregar_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            ClienteNegocio clienteNegocio = new ClienteNegocio();
             cliente = clienteNegocio.GetCliente(txtCedula.Text);
            if (cliente==null) {
                lbCliente.Text = "No se encontro el cliente";
            }
            else {
                lbCliente.Text = cliente.Nombre + " " + cliente.Apellido;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            byte byteCantidad;
            producto=productoNegocio.GetProducto(txtCodAgregar.Text);

            byte.TryParse(txtCantidadAgregar.Text, out byteCantidad);

            LineaFactura lineaFactura = new LineaFactura()
            {
                NumFacturaFk = 1,
                CodigoProducto = producto.Codigo,
                Cantidad = byteCantidad

            };

            listaProductos.Add(lineaFactura);
            llenarDGV();

            
            
        }

        private void llenarDGV() {
            int i = listaProductos.Count - 1;
                Producto producto = productoNegocio.GetProducto(listaProductos[i].CodigoProducto);
                dgvLineasFactura.Rows.Add(listaProductos[i].CodigoProducto, listaProductos[i].Cantidad, producto.Producto1, producto.Precio, (producto.Precio * listaProductos[i].Cantidad));
        }
        
    }
}
