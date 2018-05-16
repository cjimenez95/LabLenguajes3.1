using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Datos;
namespace Negocio
{
    public class ProductoFunciones
    {
        ProductoDatos productoDatos = new ProductoDatos();
        public Producto GetCliente(String ID)
        {
            int intID;
            int.TryParse(ID, out intID);
            return productoDatos.buscarProducto(intID);
        }
    }
}
