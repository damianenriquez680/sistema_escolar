using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DS3_SistemaEscolarBD.Catalogo.Carrera
{
    public partial class AgregarEditar : Form
    {
        Modelos.Carrera carrera = new Modelos.Carrera();
        public AgregarEditar(Modelos.Carrera unaCarrera)
        {
            InitializeComponent();

            carrera = unaCarrera;

            txtNombreCarrera.Text = carrera.NombreCarre;
            txtSiglasCarrera.Text = carrera.SiglasCarre;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            carrera.NombreCarre = txtNombreCarrera.Text.ToString();
            carrera.SiglasCarre = txtSiglasCarrera.Text.ToString();

            this.Close();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
