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
    public partial class CalcuSueldo : Form
    {
        public string nombre;
        private double horasTrabajadas;
        private double pagoPorHora;
        private double diasTrabajados;
        private double horasExtras;
        public double salario;
        private double diasExtras;
        private List<Empleado> empleados = new List<Empleado>();

        public CalcuSueldo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CalcuSueldo_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                nombre = txtNombre.Text;
                horasTrabajadas = double.Parse(txtHoras.Text);
                pagoPorHora = double.Parse(txtPagohora.Text);
                diasTrabajados = double.Parse(txtDias.Text);
                horasExtras = double.Parse(txthorasExtras.Text);
                salario = (horasTrabajadas + horasExtras) * pagoPorHora * diasTrabajados;
                txtSueldo.Text = salario.ToString();
                Empleado empleado = new Empleado(nombre, horasTrabajadas, pagoPorHora, diasTrabajados, horasExtras, salario);
                empleados.Add(empleado);

            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese solo números en los campos de horas trabajadas, pago por hora y días trabajados.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSueldo_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = "";
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private class Empleado
        {
            public string Nombre { get; set; }
            public double HorasTrabajadas { get; set; }
            public double PagoPorHora { get; set; }
            public double DiasTrabajados { get; set; }
            public double HorasExtras { get; set; }
            public double Salario { get; set; }

            public Empleado(string nombre, double horasTrabajadas, double pagoPorHora, double diasTrabajados, double horasExtras, double salario)
            {
                Nombre = nombre;
                HorasTrabajadas = horasTrabajadas;
                PagoPorHora = pagoPorHora;
                DiasTrabajados = diasTrabajados;
                HorasExtras = horasExtras;
                Salario = salario;
            }
        }
    }
}
