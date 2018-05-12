using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio;
using Entidad;



namespace Aplicacion
{
    public class Funciones {
     

        public static String GetClientes() {
            String strLista = "";
            List<Cliente> list = ClienteNegocio.GetClientes();
            foreach (var item in list){
                strLista += item.Nombre + " " + item.Apellido + "\n" + "Cedula: " + item.Cedula;

            }
            return strLista;
        }

    }
}
