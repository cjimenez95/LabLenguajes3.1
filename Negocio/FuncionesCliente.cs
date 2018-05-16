using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;
using System.Text.RegularExpressions;





namespace Negocio
{
    public class FuncionesCliente
    {




        //public void CapturarDatos(String id, String nombre, String apellido, String telefono,
        //String email)
        //{

        //    if (IsValidEmail(email) && IsValidID(id))
        //    {
        //        Cliente cliente = new Cliente()
        //        {
        //            Nombre = nombre,
        //            Apellido = apellido,
        //            Telefono = Convert.ToDecimal(telefono),
        //            CorreoElectronico = email,
        //            Cedula = Convert.ToDecimal(id)
        //    };
        //        using (
        //            DBLabLenguejesEntities db = new DBLabLenguejesEntities())
        //        {
        //            db.Cliente.Add(cliente);
                   
        //            try
        //            {
        //                db.SaveChanges();
        //            }
        //            catch (Exception e)
        //            {
        //                Console.WriteLine(e);
        //                // Make some adjustments.
        //                // ...
        //                // Try again.
        //              //  db.SubmitChanges();
        //            }
        //        }
        //    }  
        //    }

        
         public  bool IsValidEmail(string strIn)
            {
                // Return true if strIn is in valid e-mail format.
                return Regex.IsMatch(strIn,
                @"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$");
            }
        //public bool IsValidID(String id)
        //{
        //    decimal id2 = Convert.ToDecimal(id);
        //    return ClienteNegocio.GetClientes().Any(i => i.Cedula == id2);
        //}

 
    }
}

