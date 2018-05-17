using System;
using System.Collections.Generic;
using System.Linq;
using Datos;
using Entidad;

namespace Negocio
{


    public class ProductoNegocio
    {
        private ProductoDatos productoDatos = new ProductoDatos();
        Validaciones validaciones = new Validaciones();


        public List<Producto> GetProductos()
        {
            return productoDatos.GetProductos().ToList();
        }

        public Producto buscarProducto(String codigo)
        {
            return productoDatos.buscarProducto(codigo);
        }

        public void eliminarProducto(String codigo)
        {
            int intCodigo;
            int.TryParse(codigo, out intCodigo);
            productoDatos.eliminarProducto(codigo);
        }

        public void addProducto(String codigo, String descripcion, String precioVenta, String cantidadInventario)
        {

            decimal decimalPrecio;
            decimal.TryParse(precioVenta, out decimalPrecio);
            int intCantidad;
            int.TryParse(cantidadInventario, out intCantidad);


            if (productoDatos.buscarProducto(codigo) is null)
            {

                Producto producto = new Producto()
                {
                    Codigo = codigo,
                    Producto1 = descripcion,
                    Precio = decimalPrecio,
                    Cantidad = intCantidad
                };
                if (validaciones.soloNumeros(precioVenta) ||
                    validaciones.soloNumeros(cantidadInventario))
                {
                    throw new Exception("El codigo, el precio y la cantidad deben ser numeros");
                }
                else
                {
                    if (validaciones.validarTamanno(codigo) ||
                    validaciones.validarTamanno(precioVenta) ||
                    validaciones.validarTamanno(descripcion) ||
                    validaciones.validarTamanno(cantidadInventario))
                    {
                        throw new Exception("No pueden haber espacios en blanco");
                    }
                    else
                    {
                        if (codigo.Length > 50 ||
                        precioVenta.Length > 15 ||
                        descripcion.Length > 50 ||
                        cantidadInventario.Length > 10)
                        {
                            throw new Exception("No puede ingresar textos tan grandes maximos \n" +
                            "permitidos para el codigo y descripcion 50 \n" +
                            "caracteres, para el precio de venta y cantidad \n" +
                            "de inventario 10");
                        }
                    }
                }
                    productoDatos.agregarProducto(producto);

            }
            else
            {
                throw new Exception("ya existe este producto, vaya a la opcion de modificar");
            }
        }



        public void modificarProducto(Producto producto, String codigo, String descripcion, String precioVenta, String cantidadInventario)
        {
            decimal decimalPrecio;
            decimal.TryParse(precioVenta, out decimalPrecio);
            int intCantidad;
            int.TryParse(cantidadInventario, out intCantidad);
            Producto nuevoProducto = new Producto()
            {
                Codigo = codigo,
                Producto1 = descripcion,
                Precio = decimalPrecio,
                Cantidad = intCantidad
            };
            productoDatos.modificarProducto(producto, nuevoProducto);
        }

        public Producto GetProducto(String codigo)
        {
            return productoDatos.GetProducto(codigo);
        }
    }
} 

