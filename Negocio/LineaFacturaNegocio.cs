using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;

namespace Negocio
{
    public class LineaFacturaNegocio
    {

        public decimal totalFactura(int numFactura) {
            LineaFacturaDatos facturaDatos = new LineaFacturaDatos();
            ProductoNegocio productoNegocio = new ProductoNegocio();
            decimal totalFactura=0;
            foreach (var item in facturaDatos.getLineaFacturas())
            {
                if (item.NumFacturaFk==numFactura)
                {
                    Producto producto = productoNegocio.buscarProducto(item.CodigoProducto);
                    totalFactura += (item.Cantidad*producto.Precio);
                }
            }
            return totalFactura;
        }
    }
}
