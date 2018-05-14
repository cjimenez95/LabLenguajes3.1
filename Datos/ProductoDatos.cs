using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Datos
{

    public class ProductoDatos
    {
        DBLabLenguejesEntities dB = new DBLabLenguejesEntities();


        public List<Producto> GetProductos()
        {
            return dB.Producto.ToList();
        }

        public void agregarProducto(Producto producto)
        {
            dB.Producto.Add(producto);
            dB.SaveChanges();
        }

        public Producto buscarProducto(int codigo)
        {
            dB.SaveChanges();
            return dB.Producto.Find(codigo);
        }

        public void eliminarProducto(int codigo)
        {
            dB.Producto.Remove(buscarProducto(codigo));
            dB.SaveChanges();
        }

        public void modificarProducto(Producto producto, Producto nuevoProducto) {
            producto.Codigo = nuevoProducto.Codigo;
            producto.Producto1 = nuevoProducto.Producto1;
            producto.Precio = nuevoProducto.Precio;
            producto.Cantidad = producto.Cantidad;
        }

        public Producto GetProducto(String codigo) {
            return dB.Producto.Find(codigo);
        }
    }
}
