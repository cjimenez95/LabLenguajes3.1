using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Aplicacion
{
    public partial class ListaClientes : Form
    {
        public ListaClientes()
        {
            InitializeComponent();
           
        }

        private void btCargarCliente_Click(object sender, EventArgs e)
        {
            lbListaClientes.Text+=Funciones.GetClientes();
        }
    }
}
