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
using System.Diagnostics.SymbolStore;

namespace InfoNomina
{
    public partial class Ordenar : Form
    {
        public static List<string> nombres = new List<string>();
        public static List<double> sueldos = new List<double>();
         
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
            dataTable.Columns.Add("Sueldos");

            if (nombres.Count != sueldos.Count)
            {
                MessageBox.Show("La cantidad de nombres no coincide con la cantidad de sueldos.");
                return;
            }

            for (int i = 0; i < nombres.Count; i++)
            {
                dataTable.Rows.Add(nombres[i], sueldos[i]);
            }

            dataGridView1.DataSource = dataTable;


        }

        private void Ordenar_Load(object sender, EventArgs e)
        {

        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            nombres.Sort();
            sueldos.Sort();
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Apellidos");
            dataTable.Columns.Add("Sueldos");

            if (nombres.Count != sueldos.Count)
            {
                MessageBox.Show("La cantidad de nombres no coincide con la cantidad de sueldos.");
                return;
            }

            for (int i = 0; i < nombres.Count; i++)
            {
                dataTable.Rows.Add(nombres[i], sueldos[i]);
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

        private void button3_Click(object sender, EventArgs e)
        {
            nombres.Sort();
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Apellidos");
            dataTable.Columns.Add("Sueldos");

            if (nombres.Count != sueldos.Count)
            {
                MessageBox.Show("La cantidad de nombres no coincide con la cantidad de sueldos.");
                return;
            }

            for (int i = 0; i < nombres.Count; i++)
            {
                dataTable.Rows.Add(nombres[i], sueldos[i]);
            }

            dataGridView1.DataSource = dataTable;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            sueldos.Sort();
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Apellidos");
            dataTable.Columns.Add("Sueldos");

            if (nombres.Count != sueldos.Count)
            {
                MessageBox.Show("La cantidad de nombres no coincide con la cantidad de sueldos.");
                return;
            }

            for (int i = 0; i < nombres.Count; i++)
            {
                dataTable.Rows.Add(nombres[i], sueldos[i]);
            }

            dataGridView1.DataSource = dataTable;

        }
    }
}
