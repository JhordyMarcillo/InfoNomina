using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace InfoNomina
{
    public partial class CalcuSueldo : Form
    {
        private List<InfoNomina.IngresoDato.Empleado> listaEmpleados;

        public string nombre;
        private double diasTrabajados;
        private double horasExtras;
        public double salario;

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

            IngresoDato.Empleado empleadoEncontrado = IngresoDato.BuscarEmpleadoPorCodigo(codigoBusqueda);

            if (empleadoEncontrado != null)
            {
                txtApellido.Text = empleadoEncontrado.Apellidos;
                txtNombre.Text = empleadoEncontrado.Nombres;
                txtPagohora.Text = empleadoEncontrado.PagoPorHoras.ToString();
                txtHoras.Text = empleadoEncontrado.HorasTrabajadas.ToString();
                MessageBox.Show("Su codigo fue ingresado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string codigoBusqueda = txtCodigo.Text;

            IngresoDato.Empleado empleadoEncontrado = IngresoDato.BuscarEmpleadoPorCodigo(codigoBusqueda);

            if (empleadoEncontrado != null)
            {
                double pagoPorHora = empleadoEncontrado.PagoPorHoras;
                double horasTrabajadas = empleadoEncontrado.HorasTrabajadas;
                if (!ValidarCampos())
                    return;

                diasTrabajados = double.Parse(txtMes.Text);
                horasExtras = double.Parse(txthorasExtras.Text);

                float salario = (float)(pagoPorHora * (horasTrabajadas + horasExtras) * diasTrabajados);

                txtSalario.Text = salario.ToString();
            }
            else
            {
                MessageBox.Show("Codigo ingresado incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCampos()
        {
            if (!double.TryParse(txtMes.Text, out diasTrabajados))
            {
                MessageBox.Show("El número de días trabajados debe ser un número válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!double.TryParse(txthorasExtras.Text, out horasExtras))
            {
                MessageBox.Show("El número de horas extras debe ser un número válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void txthorasExtras_TextChanged_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txthorasExtras.Text))
            {
                int dias;
                if (!int.TryParse(txthorasExtras.Text, out dias))
                {
                    MessageBox.Show("Los horas extras deben ser un número válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txthorasExtras.Text = ""; // Limpiar el campo
                    return;
                }

                if (dias < 0 || dias > 50)
                {
                    MessageBox.Show("Los días deben estar en el rango de 1 a 50.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txthorasExtras.Text = ""; // Limpiar el campo
                    return;
                }
            }
        }

        private void txtMes_TextChanged_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMes.Text))
            {
                int dias;
                if (!int.TryParse(txtMes.Text, out dias))
                {
                    MessageBox.Show("Los días deben ser un número válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMes.Text = ""; // Limpiar el campo
                    return;
                }

                if (dias < 1 || dias > 31)
                {
                    MessageBox.Show("Los días deben estar en el rango de 1 a 31.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMes.Text = ""; // Limpiar el campo
                    return;
                }
            }
        }

        private void txtCodigo_TextChanged_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodigo.Text) && !Regex.IsMatch(txtCodigo.Text, "^[a-zA-Z0-9]+$"))
            {
                MessageBox.Show("El código debe contener solo letras y números.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodigo.Text = "";
            }
        }
    }
}