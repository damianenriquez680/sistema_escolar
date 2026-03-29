using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DS3_SistemaEscolarBD.Catalogo.Pais
{
    public partial class AgregarEditar : Form
    {
        Modelos.Pais pais = new Modelos.Pais();
        public AgregarEditar(Modelos.Pais unPais)
        {
            InitializeComponent();

            pais = unPais;

            txtNomPais.Text = pais.NombrePais;
            txtSiglasPais.Text = pais.SiglaPais;
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            pais.NombrePais = txtNomPais.Text.ToString();
            pais.SiglaPais = txtSiglasPais.Text.ToString();

            this.Close();
        }
    }
}
