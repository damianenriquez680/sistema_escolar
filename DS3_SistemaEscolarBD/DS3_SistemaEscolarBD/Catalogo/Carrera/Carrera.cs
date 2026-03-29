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
    public partial class Carrera : Form
    {
        ConexionBD conexion = new ConexionBD();
        private string txtConsultaObtener = "SELECT * FROM vwCarreraInformacion";

        public Carrera()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnObtenerDatos_Click(object sender, EventArgs e)
        {
            dgvDatosCarrera.DataSource = conexion.ObtieneDatosBD(txtConsultaObtener);
        }

        private void btnAgregarNuevaVentana_Click(object sender, EventArgs e)
        {
            Modelos.Carrera carrera = new Modelos.Carrera();

            Catalogo.Carrera.AgregarEditar nuevaVentana = new Catalogo.Carrera.AgregarEditar(carrera);
            nuevaVentana.ShowDialog();

            if (carrera.NombreCarre != null)
            {
                string[] nombres = { "NombreCarrera", "SiglasCarrera" };

                object[] valores = { carrera.NombreCarre, carrera.SiglasCarre };

                int renglonesfectados = conexion.InsertarDatosBD("stpCarreraInserta", nombres, valores);

                if (renglonesfectados >= 1)
                {
                    dgvDatosCarrera.DataSource = conexion.ObtieneDatosBD(txtConsultaObtener);
                }
            }
        }

        private void btnEditarNuevaVentana_Click(object sender, EventArgs e)
        {
            Modelos.Carrera carrera = new Modelos.Carrera();
            int IDSeleccionado = 0;

            if (dgvDatosCarrera.SelectedRows != null && dgvDatosCarrera.SelectedRows.Count > 0)
            {
                IDSeleccionado = int.Parse(dgvDatosCarrera.SelectedRows[0].Cells[0].Value.ToString());
                DataGridViewRow r = dgvDatosCarrera.SelectedRows[0];
                carrera.NombreCarre = r.Cells["Nombre"].Value.ToString();
                carrera.SiglasCarre = r.Cells["Siglas"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Debes seleccionar un registro.");
                return;
            }

            Catalogo.Carrera.AgregarEditar nuevaVentana = new Catalogo.Carrera.AgregarEditar(carrera);
            nuevaVentana.ShowDialog();

            if (carrera.NombreCarre != null)
            {
                string[] nombres = { "IDCarrera", "NombreCarrera", "SiglasCarrera" };

                object[] valores = { IDSeleccionado, carrera.NombreCarre, carrera.SiglasCarre };

                int renglonesfectados = conexion.EditarDatosBD("stpCarreraActualiza", nombres, valores);

                if (renglonesfectados >= 1)
                {
                    dgvDatosCarrera.DataSource = conexion.ObtieneDatosBD(txtConsultaObtener);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int IDSeleccionado = 0;
            if (dgvDatosCarrera.SelectedRows != null && dgvDatosCarrera.SelectedRows.Count > 0)
            {
                IDSeleccionado = int.Parse(dgvDatosCarrera.SelectedRows[0].Cells[0].Value.ToString());
            }
            else
            {
                MessageBox.Show("Debes seleccionar un registro.");
                return;
            }

            string nombre = "IDCarrera";
            object valor = IDSeleccionado;

            int renglonesfectados = conexion.EliminarDatosBD("stpCarreraElimina", nombre, valor);

            if (renglonesfectados >= 1)
            {
                dgvDatosCarrera.DataSource = conexion.ObtieneDatosBD(txtConsultaObtener);
            }
        }
    }
}
