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
        public static List<float> sueldos = new List<float>();
         
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
            MergeSortNombres(nombres);
            MergeSortSueldos(sueldos);

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
            MergeSortNombres(nombres);
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
            MergeSortSueldos(sueldos);
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
        private void MergeSortNombres(List<string> nombres)
        {
            if (nombres.Count <= 1)
                return;

            int medio = nombres.Count / 2;
            List<string> izquierda = new List<string>();
            List<string> derecha = new List<string>();

            for (int i = 0; i < medio; i++)
            {
                izquierda.Add(nombres[i]);
            }

            for (int i = medio; i < nombres.Count; i++)
            {
                derecha.Add(nombres[i]);
            }

            MergeSortNombres(izquierda);
            MergeSortNombres(derecha);
            MergeNombres(nombres, izquierda, derecha);
        }

        private void MergeNombres(List<string> nombres, List<string> izquierda, List<string> derecha)
        {
            int i = 0, j = 0, k = 0;
            while (i < izquierda.Count && j < derecha.Count)
            {
                if (izquierda[i].CompareTo(derecha[j]) < 0)
                {
                    nombres[k] = izquierda[i];
                    i++;
                }
                else
                {
                    nombres[k] = derecha[j];
                    j++;
                }
                k++;
            }

            while (i < izquierda.Count)
            {
                nombres[k] = izquierda[i];
                i++;
                k++;
            }

            while (j < derecha.Count)
            {
                nombres[k] = derecha[j];
                j++;
                k++;
            }
        }

        private void MergeSortSueldos(List<float> sueldos)
        {
            if (sueldos.Count <= 1)
                return;

            int medio = sueldos.Count / 2;
            List<float> izquierda = new List<float>();
            List<float> derecha = new List<float>();

            for (int i = 0; i < medio; i++)
            {
                izquierda.Add(sueldos[i]);
            }

            for (int i = medio; i < sueldos.Count; i++)
            {
                derecha.Add(sueldos[i]);
            }

            MergeSortSueldos(izquierda);
            MergeSortSueldos(derecha);
            MergeSueldos(sueldos, izquierda, derecha);
        }

        private void MergeSueldos(List<float> sueldos, List<float> izquierda, List<float> derecha)
        {
            int i = 0, j = 0, k = 0;
            while (i < izquierda.Count && j < derecha.Count)
            {
                if (izquierda[i] < derecha[j])
                {
                    sueldos[k] = izquierda[i];
                    i++;
                }
                else
                {
                    sueldos[k] = derecha[j];
                    j++;
                }
                k++;
            }

            while (i < izquierda.Count)
            {
                sueldos[k] = izquierda[i];
                i++;
                k++;
            }

            while (j < derecha.Count)
            {
                sueldos[k] = derecha[j];
                j++;
                k++;
            }
        }
    }
}