using System;
using System.Windows.Forms;
using Negocio;

namespace prueba
{
    public partial class AgregarCliente : Form
    {
        public AgregarCliente()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteNegocio clienteNegocio = new ClienteNegocio();
                clienteNegocio.agregarCliente(MTBCedula.Text, TBNombre.Text, TBApellido.Text, TBEmail.Text, MTBTelefono.Text);
                MTBCedula.Clear();
               TBNombre.Clear();
                TBApellido.Clear();
                TBEmail.Clear(); 
                MTBTelefono.Clear();
                MessageBox.Show("Cliente ingresado");
            }
            catch (Exception em)
            {
                MessageBox.Show("" + em.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btAtras_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.Show();
            this.Hide();
        }
    }
    }

