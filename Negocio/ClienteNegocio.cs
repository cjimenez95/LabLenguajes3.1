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
        Validaciones validaciones = new Validaciones();

        public  List<Cliente> GetClientes() {
            return clienteDatos.GetClientes();
        }

        public Cliente agregarCliente(String id, String nombre, String apellido, string correo, String telefono) {
            int intId;
            int.TryParse(id, out intId);
            int intTelefono;
            int.TryParse(telefono, out intTelefono);

            if (clienteDatos.buscarCliente(intId) is null)
            {
                Cliente cliente = new Cliente()
                {
                    Nombre = nombre.Trim(),
                    Apellido = apellido,
                    Telefono = intTelefono,
                    CorreoElectronico = correo,
                    Cedula = intId
                };
                if (validaciones.soloLetras(nombre) ||
                validaciones.soloLetras(apellido))
                {
                    throw new Exception("El nombre y el apellido solo pueden tener letras");
                }
                else
                {
                    if (!validaciones.correo(correo))
                    {
                        throw new Exception("Formato incorrecto del correo");
                    }
                
                else {
                    if (validaciones.validarTamanno(nombre) ||
                    validaciones.validarTamanno(apellido) ||
                    validaciones.validarTamanno(id) ||
                    validaciones.validarTamanno(correo) ||
                    validaciones.validarTamanno(telefono))
                    {
                        throw new Exception("Debe llenar todos los campos solicitados");
                    }
                    else
                    {

                        if (nombre.Length > 50 ||
                        apellido.Length > 50 ||
                        id.Length < 7 ||
                        correo.Length > 50 ||
                        telefono.Length < 14)
                        {
                            throw new Exception("no puede ingresar datos mayores a 20 caracteres\n" +
                            " o el formato de la cedula o numero es incorrecto ");
                        }
                    }
                }
            } 
            clienteDatos.agregarCliente(cliente);
                return cliente;
            }
            else
            {
                throw new Exception("ya existe este cliente");
            }
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
