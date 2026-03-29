using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DS3_SistemaEscolarBD.Catalogo.Materia
{
    public partial class AgregarEditar : Form
    {
        Modelos.Materia materia = new Modelos.Materia();
        public AgregarEditar(Modelos.Materia unaMateria)
        {
            InitializeComponent();

            materia = unaMateria;

            txtNombreMateria.Text = materia.NombreMateria;
            nCreditos.Value = materia.Creditos;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            materia.NombreMateria = txtNombreMateria.Text.ToString();
            materia.Creditos = int.Parse(nCreditos.Value.ToString());

            this.Close();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
