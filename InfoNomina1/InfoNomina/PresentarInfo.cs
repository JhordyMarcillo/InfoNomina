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
    public partial class PresentarInfo : Form
    {
        // Declarar las listas de nombres y pago
        public static List<string> codigo = new List<string>();
        public static List<string> apellidos = new List<string>();
        public static List<string> nombres = new List<string>();
        public static List<string> cargo = new List<string>();
        public static List<float> pagoPorHoras = new List<float>();
        public static List<float> horasTrabajadas = new List<float>();
        public PresentarInfo()
        {
            InitializeComponent();
        }

        private void Btn_Show_Click(object sender, EventArgs e)
        {
            OrdenarNombres();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OrdenarNombres()
        {
            // Crear un DataTable para almacenar la información de los empleados
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Código");
            dataTable.Columns.Add("Apellidos");
            dataTable.Columns.Add("Nombres");
            dataTable.Columns.Add("Cargo");
            dataTable.Columns.Add("Pago por Hora");
            dataTable.Columns.Add("Horas Trabajadas");

            // Verificar si hay al menos un empleado
            if (codigo.Count > 0)
            {
                // Iterar sobre todos los empleados y agregar sus datos al DataTable
                for (int i = 0; i < codigo.Count; i++)
                {
                    dataTable.Rows.Add(codigo[i], apellidos[i], nombres[i], cargo[i], pagoPorHoras[i], horasTrabajadas[i]);
                }
            }

            // Mostrar el DataTable en el DataGridView
            dataGridView1.DataSource = dataTable;

        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
