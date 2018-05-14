using System.Collections.Generic;
using System.Linq;
using Entidad;

namespace Datos
{
    public class ClienteDatos
    {
        DBLabLenguejesEntities db = new DBLabLenguejesEntities();

        public List<Cliente> GetClientes()
        {
            return db.Cliente.ToList();
        }

        public void agregarCliente(Cliente cliente)
        {
            db.Cliente.Add(cliente);
            db.SaveChanges();
        }

        public Cliente buscarCliente(int cedula)
        {
            return db.Cliente.Find(cedula);
        }

        public void eliminarCliente(int cedula) {
            db.Cliente.Remove(buscarCliente(cedula));
            db.SaveChanges();
        }

        public void modificarCliente(Cliente cliente, Cliente nuevoCliente)
        {
            cliente = nuevoCliente;
            db.Cliente.Find(cliente.Cedula).Telefono = nuevoCliente.Telefono;
            db.SaveChanges();
        }
        
        
    }
}
