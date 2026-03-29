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
    public partial class Estatus : Form
    {
        ConexionBD conexion = new ConexionBD();
        private string txtConsultaObtener = "SELECT * FROM vwEstatusInformacion";
        public Estatus()
        {
            InitializeComponent();
        }

        private void btnObtenerDatos_Click(object sender, EventArgs e)
        {
            dgvDatosEstatus.DataSource = conexion.ObtieneDatosBD(txtConsultaObtener);
        }

        private void btnAgregarNuevaVentana_Click(object sender, EventArgs e)
        {
            Modelos.Estatus estatus = new Modelos.Estatus();

            Catalogo.Estatus.AgregarEditar nuevaVentana = new Catalogo.Estatus.AgregarEditar(estatus);
            nuevaVentana.ShowDialog();

            if (estatus.NombreEstatus != null)
            {
                string[] nombres = { "ClaveEstatus", "NombreEstatus", "Usuario" };

                object[] valores = { estatus.ClaveEstatus, estatus.NombreEstatus, estatus.Usuario };

                int renglonesfectados = conexion.InsertarDatosBD("stpEstatusInserta", nombres, valores);

                if (renglonesfectados >= 1)
                {
                    dgvDatosEstatus.DataSource = conexion.ObtieneDatosBD(txtConsultaObtener);
                }
            }
        }

        private void btnEditarNuevaVentana_Click(object sender, EventArgs e)
        {
            Modelos.Estatus estatus = new Modelos.Estatus();
            int IDSeleccionado = 0;

            if (dgvDatosEstatus.SelectedRows != null && dgvDatosEstatus.SelectedRows.Count > 0)
            {
                IDSeleccionado = int.Parse(dgvDatosEstatus.SelectedRows[0].Cells[0].Value.ToString());
                DataGridViewRow r = dgvDatosEstatus.SelectedRows[0];
                estatus.ClaveEstatus = r.Cells["Clave"].Value.ToString();
                estatus.NombreEstatus = r.Cells["Estatus"].Value.ToString();
                estatus.Usuario = r.Cells["Usuario"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Debes seleccionar un registro.");
                return;
            }

            Catalogo.Estatus.AgregarEditar nuevaVentana = new Catalogo.Estatus.AgregarEditar(estatus);
            nuevaVentana.ShowDialog();

            if (estatus.NombreEstatus != null)
            {
                string[] nombres = { "IDEstatus", "ClaveEstatus", "NombreEstatus", "Usuario" };

                object[] valores = { IDSeleccionado, estatus.ClaveEstatus, estatus.NombreEstatus, estatus.Usuario };

                int renglonesfectados = conexion.EditarDatosBD("stpEstatusActualiza", nombres, valores);

                if (renglonesfectados >= 1)
                {
                    dgvDatosEstatus.DataSource = conexion.ObtieneDatosBD(txtConsultaObtener);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int IDSeleccionado = 0;
            if (dgvDatosEstatus.SelectedRows != null && dgvDatosEstatus.SelectedRows.Count > 0)
            {
                IDSeleccionado = int.Parse(dgvDatosEstatus.SelectedRows[0].Cells[0].Value.ToString());
            }
            else
            {
                MessageBox.Show("Debes seleccionar un registro.");
                return;
            }

            string nombre = "IDEstatus";
            object valor = IDSeleccionado;

            int renglonesfectados = conexion.EliminarDatosBD("stpEstatusElimina", nombre, valor);

            if (renglonesfectados >= 1)
            {
                dgvDatosEstatus.DataSource = conexion.ObtieneDatosBD(txtConsultaObtener);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
