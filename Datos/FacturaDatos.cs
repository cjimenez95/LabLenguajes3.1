using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Datos
{
   public class FacturaDatos
    {

        DBLabLenguejesEntities db = new DBLabLenguejesEntities();

        public void crearFactuta(Cliente cliente, List<LineaFactura> lineas) {
            int numeroFactura = getUltimaFactura();
            Factura factura = new Factura()
            {
                NumFactura = numeroFactura+1,
                FechaHora = DateTime.Now,
                CedulaCliente=cliente.Cedula
            };
            db.Factura.Add(factura);

            agregarLineas(factura.NumFactura, lineas);
            db.SaveChanges();
           
        }

        private void agregarLineas(int factura, List<LineaFactura> lineas) {
            foreach (var item in lineas)
            {
                LineaFactura lineaFactura = new LineaFactura()
                {
                    Cantidad = item.Cantidad,
                    CodigoProducto=item.CodigoProducto,
                    NumFacturaFk=factura
                   
                };
                db.LineaFactura.Add(lineaFactura);
            }
        }

        private int getUltimaFactura() {
            List<Factura> listFacturas=db.Factura.ToList();
            if (listFacturas.Count==0)
            {
                return 0;
            }
            else
            {
                return listFacturas[listFacturas.Count - 1].NumFactura;
            }  
        }

        public List<Factura> getFacturas()
        {
            return db.Factura.ToList();
        }

    }
}
