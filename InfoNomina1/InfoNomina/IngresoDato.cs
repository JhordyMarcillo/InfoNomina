using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoNomina
{
    public partial class IngresoDato : Form
    {
        public static List<string> nombres = new List<string>();

        public IngresoDato()
        {
            InitializeComponent();
        }

        private void IngresoDato_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            Ordenar.nombres.Add(nombre);
            MessageBox.Show("Los datos se ingresaron correctamente");
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {

        }
    }
}
