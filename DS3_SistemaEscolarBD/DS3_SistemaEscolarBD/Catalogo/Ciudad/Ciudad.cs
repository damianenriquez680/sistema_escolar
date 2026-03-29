using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DS3_SistemaEscolarBD.Catalogo.Ciudad
{
    public partial class Ciudad : Form
    {
        ConexionBD conexion = new ConexionBD();
        private string txtConsultaObtener = "SELECT * FROM vwCiudadInformacion";
        public Ciudad()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnObtenerDatos_Click(object sender, EventArgs e)
        {
            dgvDatosCiudad.DataSource = conexion.ObtieneDatosBD(txtConsultaObtener);
        }

        private void btnAgregarNuevaVentana_Click(object sender, EventArgs e)
        {
            Modelos.Ciudad ciudad = new Modelos.Ciudad();

            Catalogo.Ciudad.AgregarEditar nuevaVentana = new Catalogo.Ciudad.AgregarEditar(ciudad);
            nuevaVentana.ShowDialog();

            if (ciudad.NombreCiudad != null)
            {
                string[] nombres = { "NombreCiudad", "SiglasCiudad", "IDEstado" };

                object[] valores = { ciudad.NombreCiudad, ciudad.SiglasCiudad, ciudad.IDEstado };

                int renglonesfectados = conexion.InsertarDatosBD("stpCiudadInserta", nombres, valores);

                if (renglonesfectados >= 1)
                {
                    dgvDatosCiudad.DataSource = conexion.ObtieneDatosBD(txtConsultaObtener);
                }
            }
        }

        private void btnEditarNuevaVentana_Click(object sender, EventArgs e)
        {
            Modelos.Ciudad ciudad = new Modelos.Ciudad();
            int IDSeleccionado = 0;

            if (dgvDatosCiudad.SelectedRows != null && dgvDatosCiudad.SelectedRows.Count > 0)
            {
                IDSeleccionado = int.Parse(dgvDatosCiudad.SelectedRows[0].Cells[0].Value.ToString());
                DataGridViewRow r = dgvDatosCiudad.SelectedRows[0];
                ciudad.NombreCiudad = r.Cells["Nombre"].Value.ToString();
                ciudad.SiglasCiudad = r.Cells["Siglas"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Debes seleccionar un registro.");
                return;
            }

            Catalogo.Ciudad.AgregarEditar nuevaVentana = new Catalogo.Ciudad.AgregarEditar(ciudad);
            nuevaVentana.ShowDialog();

            if (ciudad.NombreCiudad != null)
            {
                string[] nombres = { "IDCiudad", "NombreCiudad", "SiglasCiudad", "IDEstado" };

                object[] valores = { IDSeleccionado, ciudad.NombreCiudad, ciudad.SiglasCiudad, ciudad.IDEstado };

                int renglonesfectados = conexion.EditarDatosBD("stpCiudadActualiza", nombres, valores);

                if (renglonesfectados >= 1)
                {
                    dgvDatosCiudad.DataSource = conexion.ObtieneDatosBD(txtConsultaObtener);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int IDSeleccionado = 0;
            if (dgvDatosCiudad.SelectedRows != null && dgvDatosCiudad.SelectedRows.Count > 0)
            {
                IDSeleccionado = int.Parse(dgvDatosCiudad.SelectedRows[0].Cells[0].Value.ToString());
            }
            else
            {
                MessageBox.Show("Debes seleccionar un registro.");
                return;
            }

            string nombre = "IDCiudad";
            object valor = IDSeleccionado;

            int renglonesfectados = conexion.EliminarDatosBD("stpCiudadElimina", nombre, valor);

            if (renglonesfectados >= 1)
            {
                dgvDatosCiudad.DataSource = conexion.ObtieneDatosBD(txtConsultaObtener);
            }
        }
    }
}
