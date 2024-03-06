using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static InfoNomina.IngresoDato;
using static InfoNomina.CalcuSueldo;

namespace InfoNomina
{
    public partial class Ordenar : Form
    {
        public static List<string> nombres = new List<string>();
        public static List<bool> pago = new List<bool>();
        public Ordenar()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Apellidos");

            foreach (string nombre in nombres)
            {
                dataTable.Rows.Add(nombre);
            }
            dataGridView1.DataSource = dataTable;

        }

        private void Ordenar_Load(object sender, EventArgs e)
        {

        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            nombres.Sort();
            pago.Sort();
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Apellidos");
            dataTable.Columns.Add("Pago por Hora");
            dataTable.Columns.Add("Horas Trabajadas");

            foreach (string nombre in nombres)
            {
                dataTable.Rows.Add(nombre);
            }
            dataGridView1.DataSource = dataTable;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
