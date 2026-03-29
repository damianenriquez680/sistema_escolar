using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DS3_SistemaEscolarBD.Catalogo.Estatus
{
    public partial class AgregarEditar : Form
    {
        Modelos.Estatus estatus = new Modelos.Estatus();
        public AgregarEditar(Modelos.Estatus unEstatus)
        {
            InitializeComponent();

            estatus = unEstatus;

            txtClaveEstatus.Text = estatus.ClaveEstatus;
            cbEstatus.SelectedItem = estatus.NombreEstatus;
            txtUsuario.Text = estatus.Usuario;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            estatus.NombreEstatus = cbEstatus.SelectedItem.ToString();
            estatus.ClaveEstatus = txtClaveEstatus.Text.ToString();
            estatus.Usuario = txtUsuario.Text.ToString();

            this.Close();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
