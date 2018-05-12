using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prueba;

namespace presentacion
{
    public partial class ListaProductos : Form
    {
        public ListaProductos()
        {
            InitializeComponent();
        }

        private void ListaProductos_Load(object sender, EventArgs e)
        {

        }

        private void btAtras_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.Show();
            this.Dispose();
        }
    }
}
