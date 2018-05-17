using System.Collections.Generic;
using System.Linq;
using Entidad;

namespace Datos
{
   public class LineaFacturaDatos
    {
        DBLabLenguejesEntities db = new DBLabLenguejesEntities();
        public List<LineaFactura> getLineaFacturas() {
            return db.LineaFactura.ToList();
        }
    }
}
