using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DS3_SistemaEscolarBD.Catalogo.Aula
{
    public partial class AgregarEditar : Form
    {
        Modelos.Aula aula = new Modelos.Aula();
        public AgregarEditar(Modelos.Aula unAula)
        {
            InitializeComponent();

            aula = unAula;

            txtEdificio.Text = aula.Edificio;
            txtNombreAula.Text = aula.NombreAula;
            txtPiso.Text = aula.Piso;
            txtCapaMax.Text = aula.CapaMax.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            aula.NombreAula = txtNombreAula.Text.ToString();
            aula.Edificio = txtEdificio.Text;
            aula.Piso = txtPiso.Text;
            aula.CapaMax = int.Parse(txtCapaMax.Text.ToString());

            this.Close();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
