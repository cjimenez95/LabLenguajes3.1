using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;

namespace Negocio
{

 
   public  class ProductoNegocio
    {
        ProductoDatos productoDatos = new ProductoDatos();
       

        public List<Producto> GetProductos() {
            return productoDatos.GetProductos().ToList();
        }

        public Producto buscarProducto(String codigo) {
            int intCodigo;
            int.TryParse(codigo, out intCodigo);
            return productoDatos.buscarProducto(intCodigo);
        }

        public void eliminarProducto(String codigo) {
            int intCodigo;
            int.TryParse(codigo, out intCodigo);
            productoDatos.eliminarProducto(intCodigo);
        }

        public void addProducto(String codigo, String descripcion, String precioVenta, String cantidadInventario) {
            decimal decimalPrecio;
            decimal.TryParse(precioVenta, out decimalPrecio);
            int intCantidad;
            int.TryParse(cantidadInventario, out intCantidad);

            Producto producto = new Producto()
            {
            Codigo = codigo,
            Producto1 = descripcion,
            Precio= decimalPrecio,
            Cantidad=intCantidad
            };
            productoDatos.agregarProducto(producto);
        }


    }
}
