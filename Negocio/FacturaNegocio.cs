using System.Collections.Generic;
using Entidad;
using Datos;
using System;

namespace Negocio
{
   public class FacturaNegocio
    {
        FacturaDatos factura = new FacturaDatos();
        public void crearFacura(Cliente cliente, List<LineaFactura> lineas) {
           
            factura.crearFactuta(cliente,lineas);
        }

        public List<LineaFactura> modificarLineas(List<LineaFactura> lineas,string codigo, string cantidad) {
            byte byteCantidad;
            if (byte.TryParse(cantidad,out byteCantidad))
            {
                for (int i = 0; i < lineas.Count; i++) 
                {
                    if (lineas[i].CodigoProducto.Equals (codigo))
                    {
                        if (byteCantidad > 0)
                        {
                            lineas[i].Cantidad = byteCantidad;
                        }
                        else if (byteCantidad == 0)
                        {
                            lineas.Remove(lineas[i]);
                        }
                        else {
                            throw new ArgumentException("CANTIDAD ERROR \n Ingrese solo numeros enteros positivos");
                        }
                       
                    }
                }
                return lineas;
            }
            throw new ArgumentException("CANTIDAD ERROR \n Ingrese solo numeros enteros positivos");
        }

        public List<Factura> getFacturasCliente(string cedula, DateTime dateInicio, DateTime dateFin)
        {
            int intCedula;
            
            List<Factura> facturas = factura.getFacturas();
            List<Factura> facturasCliente = new List<Factura>();
            if (int.TryParse(cedula, out intCedula))
            {
                foreach (var item in facturas)
                {
                    if (item.CedulaCliente == intCedula && (item.FechaHora.Date>dateInicio.Date && item.FechaHora.Date<dateFin.Date || item.FechaHora.Date==dateFin.Date && item.FechaHora.Date==dateInicio.Date))
                    {
                        facturasCliente.Add(item);
                    }
                }
                return facturasCliente;
            }
            else {
                throw new ArithmeticException("Cedula invalida");
            }
            
        }
    }
}
