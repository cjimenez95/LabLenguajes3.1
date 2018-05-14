using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Datos;
using System.Text.RegularExpressions;

namespace Negocio
{
    public class ClienteNegocio{

      ClienteDatos clienteDatos = new ClienteDatos();

        public  List<Cliente> GetClientes() {
            return clienteDatos.GetClientes();
        }

        public Cliente agregarCliente(String id, String nombre, String apellido, string correo, String telefono) {
            int intId;
            int.TryParse(id, out intId);
            int intTelefono;
            int.TryParse(telefono, out intTelefono);

            Cliente cliente = new Cliente()
            {
                Nombre = nombre.Trim(),
                Apellido = apellido,
                Telefono = intTelefono,
                CorreoElectronico = correo,
                Cedula = intId
            };

            clienteDatos.agregarCliente(cliente);
            return cliente;
        }

        public bool IsValidEmail(string strIn) {
            // Return true if strIn is in valid e-mail format.
            return Regex.IsMatch(strIn,
            @"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" +
            @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$");
        }

        public Cliente GetCliente(String cedulaCliente) {
            int intCedula;
            int.TryParse(cedulaCliente, out intCedula);
            return clienteDatos.buscarCliente(intCedula);
        }

        public void eliminarCliente(String cedulaCliente) {
            int intCedula;
            int.TryParse(cedulaCliente, out intCedula);
            clienteDatos.eliminarCliente(intCedula);
        }

        public void modificarCliente(Cliente cliente, String id, String nombre, String apellido, string correo, String telefono) {
            int intId;
            int.TryParse(id, out intId);
            int intTelefono;
            int.TryParse(telefono,out intTelefono);
          

            Cliente nuevoCliente = new Cliente()
            {
                Nombre = nombre.Trim(),
                Apellido = apellido,
                Telefono = intTelefono,
                CorreoElectronico = correo,
                Cedula = intId
            };

            clienteDatos.modificarCliente(cliente,nuevoCliente);
        }


    }
}
