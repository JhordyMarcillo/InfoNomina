using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoNomina
{
    public partial class IngresoDato : Form
    {
        private static List<Empleado> listaEmpleados = new List<Empleado>(); // Declarar una lista para almacenar los empleados

        public class Empleado
        {
            public string Codigo { get; set; }
            public string Apellidos { get; set; }
            public string Nombres { get; set; }
            public string Cargo { get; set; }
            public float PagoPorHoras { get; set; }
            public float HorasTrabajadas { get; set; }
        }

        public IngresoDato()
        {
            InitializeComponent();
            txtCodigo.TextChanged += txtCodigo_TextChanged;
            txtApellidos.TextChanged += txtApellidos_TextChanged;
            txtNombre.TextChanged += txtNombre_TextChanged;
            txtCargo.TextChanged += txtCargo_TextChanged;
            txtPago.TextChanged += txtPago_TextChanged;
            txtHoras.TextChanged += txtHoras_TextChanged;
        }
        public static Empleado BuscarEmpleadoPorCodigo(string codigo)
        {
            // Busca el empleado por su código
            foreach (Empleado empleado in listaEmpleados)
            {
                if (empleado.Codigo == codigo)
                {
                    return empleado; // Devuelve el empleado encontrado
                }
            }
            return null; // Si no se encuentra, devuelve null
        }
        private void IngresoDato_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // Validar los campos antes de guardar
            if (ValidarCampos())
            {
                // Crear una instancia de Empleado y guardar los datos ingresados
                Empleado empleado = new Empleado
                {
                    Codigo = txtCodigo.Text,
                    Apellidos = txtApellidos.Text,
                    Nombres = txtNombre.Text,
                    Cargo = txtCargo.Text,
                    PagoPorHoras = float.Parse(txtPago.Text),
                    HorasTrabajadas = float.Parse(txtHoras.Text),
                };

                // Agregar el empleado a la lista
                listaEmpleados.Add(empleado);
                string apellidos = txtApellidos.Text;
                Ordenar.nombres.Add(apellidos);
                // Limpiar los campos después de guardar
                LimpiarCampos();

                // Mostrar un mensaje de éxito
                MessageBox.Show("Empleado guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodigo.Text) && !Regex.IsMatch(txtCodigo.Text, "^[a-zA-Z0-9]+$"))
            {
                MessageBox.Show("El código debe contener solo letras y números.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodigo.Text = "";
            }
        }

        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtApellidos.Text, "[0-9]"))
            {
                MessageBox.Show("Los apellidos no deben contener números.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApellidos.Text = ""; // Limpiar el campo
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtNombre.Text, "[0-9]"))
            {
                MessageBox.Show("Los nombres no deben contener números.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Text = ""; // Limpiar el campo
            }
        }

        private void txtCargo_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtCargo.Text, "[0-9]"))
            {
                MessageBox.Show("El cargo no debe contener números.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCargo.Text = ""; // Limpiar el campo
            }
        }

        private void txtPago_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPago.Text))
            {
                float result;
                if (!float.TryParse(txtPago.Text, out result))
                {
                    MessageBox.Show("El pago por horas debe ser un número válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPago.Text = ""; // Limpiar el campo
                }
            }
        }

        private void txtHoras_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtHoras.Text))
            {
                float horas;
                if (!float.TryParse(txtHoras.Text, out horas))
                {
                    MessageBox.Show("Las horas trabajadas debe ser un número válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtHoras.Text = ""; // Limpiar el campo
                }
            }
        }

        private bool ValidarCampos()
        {
            // Validar cada campo individualmente
            if (!Regex.IsMatch(txtCodigo.Text, "^[a-zA-Z0-9]+$"))
            {
                MessageBox.Show("El código debe contener solo letras y números.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (Regex.IsMatch(txtApellidos.Text, "[0-9]"))
            {
                MessageBox.Show("Los apellidos no deben contener números.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (Regex.IsMatch(txtNombre.Text, "[0-9]"))
            {
                MessageBox.Show("Los nombres no deben contener números.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (Regex.IsMatch(txtCargo.Text, "[0-9]"))
            {
                MessageBox.Show("El cargo no debe contener números.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            float result;
            if (!float.TryParse(txtPago.Text, out result))
            {
                MessageBox.Show("El pago por horas debe ser un número válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            float horas;
            if (!float.TryParse(txtHoras.Text, out horas))
            {
                MessageBox.Show("Las horas trabajadas deben ser un número entero.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        // Método para limpiar los campos después de guardar
        private void LimpiarCampos()
        {
            txtCodigo.Text = "";
            txtApellidos.Text = "";
            txtNombre.Text = "";
            txtCargo.Text = "";
            txtPago.Text = "";
            txtHoras.Text = "";
        }

        private void Btn_Atras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio inicio = new Inicio();
            inicio.Show();

        }
    }
}
