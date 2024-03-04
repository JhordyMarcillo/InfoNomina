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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Btn_IngresoDatos_Click(object sender, EventArgs e)
        {
            this.Hide();
            IngresoDato ingreso = new IngresoDato();
            ingreso.Show();
        }

        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {
            ActualizacionDatos actualizacionDatos = new ActualizacionDatos();
            actualizacionDatos.Show();
        }

        private void Btn_CalculoSueldo_Click(object sender, EventArgs e)
        {
            CalcuSueldo calcularSueldo = new CalcuSueldo();
            calcularSueldo.Show();
        }

        private void Btn_ConsultaCargo_Click(object sender, EventArgs e)
        {
            ConsulCargo consultaCargo = new ConsulCargo();
            consultaCargo.Show();
        }

        private void Btn_Ordenar_Click(object sender, EventArgs e)
        {
            Ordenar ordenar = new Ordenar();
            ordenar.Show();
        }

        private void Btn_PresentarInfo_Click(object sender, EventArgs e)
        {
            PresentarInfo presentarInfo = new PresentarInfo();
            presentarInfo.Show();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
