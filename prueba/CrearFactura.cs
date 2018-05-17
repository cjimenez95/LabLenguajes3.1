using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Negocio;
using Entidad;
using prueba;

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
            agregarLineaDGV();
            String strTotal = calcularTotal()+"";
            lbTotal.Text = strTotal.Substring(0,strTotal.Length-2);

            txtCantidadAgregar.Text="Cantidad";
            txtCodAgregar.Text= "CodigoProdcuto";
            
        }

        private void agregarLineaDGV() {
            int i = listaProductos.Count - 1;
                Producto producto = productoNegocio.GetProducto(listaProductos[i].CodigoProducto);
                dgvLineasFactura.Rows.Add(listaProductos[i].CodigoProducto, listaProductos[i].Cantidad, producto.Producto1, producto.Precio, (producto.Precio * listaProductos[i].Cantidad));
        }

        private decimal calcularTotal()
        {
            decimal total = 0;
            foreach (var item in listaProductos)
            {
                Producto producto= productoNegocio.GetProducto(item.CodigoProducto);
                total +=(item.Cantidad*producto.Precio);
            }
            return total;
        }



        private void btAtras_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.Show();
            this.Hide();
        }

        private void btGuardarFactura_Click(object sender, EventArgs e)
        {
            FacturaNegocio factura = new FacturaNegocio();
            factura.crearFacura(cliente,listaProductos);

            MessageBox.Show(text: "Factura creada");
            lbCliente.Text="";
            txtCedula.Clear();
            lbTotal.Text = "";
            dgvLineasFactura.Rows.Clear();
        }


        private void modificarDGV() {
            dgvLineasFactura.Rows.Clear();
            foreach (var item in listaProductos)
            {
                Producto producto = productoNegocio.GetProducto(item.CodigoProducto);
                dgvLineasFactura.Rows.Add(item.CodigoProducto,item.Cantidad,producto.Producto1,producto.Precio,(item.Cantidad*producto.Precio));
            }
        }
        private void btModificar_Click(object sender, EventArgs e)
        {
            FacturaNegocio factura = new FacturaNegocio();
            listaProductos= factura.modificarLineas(listaProductos,txtCodModificar.Text,txtCantidadModificar.Text);
            modificarDGV();
            String strTotal = calcularTotal() + "";
            lbTotal.Text = strTotal.Substring(0, strTotal.Length - 2);
        }
    }
}
