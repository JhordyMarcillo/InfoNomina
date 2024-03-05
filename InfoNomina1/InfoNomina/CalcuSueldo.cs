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

namespace InfoNomina
{
    public partial class CalcuSueldo : Form
    {
        private List<InfoNomina.IngresoDato.Empleado> listaEmpleados;
        private IngresoDato formularioIngresoDato;

        public string nombre;
        private double horasTrabajadas;
        private double pagoPorHora;
        private double diasTrabajados;
        private double horasExtras;
        public double salario;
        private double diasExtras;

        public CalcuSueldo(List<InfoNomina.IngresoDato.Empleado> empleados)
        {
            InitializeComponent();
            listaEmpleados = empleados;
        }
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
            string codigoBusqueda = txtCodigo.Text;

            // Llama al método estático directamente, no necesitas una instancia de IngresoDato
            IngresoDato.Empleado empleadoEncontrado = IngresoDato.BuscarEmpleadoPorCodigo(codigoBusqueda);

            if (empleadoEncontrado != null)
            {
                // Llena los campos con los datos del empleado encontrado
                txtApellido.Text = empleadoEncontrado.Apellidos;
                txtNombre.Text = empleadoEncontrado.Nombres;
                txtPagohora.Text = empleadoEncontrado.PagoPorHoras.ToString();
                txtHoras.Text = empleadoEncontrado.HorasTrabajadas.ToString();
            }
            else
            {
                MessageBox.Show("No se encontró ningún empleado con el código especificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            this.Hide();
            Inicio inicio = new Inicio();
            inicio.Show();
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

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string codigoBusqueda = txtCodigo.Text;

            // Buscar el empleado por código
            IngresoDato.Empleado empleadoEncontrado = IngresoDato.BuscarEmpleadoPorCodigo(codigoBusqueda);

            if (empleadoEncontrado != null)
            {
                // Obtener el pago por horas y las horas trabajadas del empleado encontrado
                double pagoPorHora = empleadoEncontrado.PagoPorHoras;
                double horasTrabajadas = empleadoEncontrado.HorasTrabajadas;
                diasTrabajados = double.Parse(txtMes.Text);
                horasExtras = double.Parse(txthorasExtras.Text);

                // Calcular el salario multiplicando el pago por horas y las horas trabajadas
                double salario = pagoPorHora * (horasTrabajadas+horasExtras) * diasTrabajados;

                // Mostrar el salario en el campo txtSalario
                txtSalario.Text = salario.ToString();
            }
            else
            {
                MessageBox.Show("No se encontró ningún empleado con el código especificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
