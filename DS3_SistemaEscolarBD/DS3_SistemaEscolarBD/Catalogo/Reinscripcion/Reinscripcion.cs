using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DS3_SistemaEscolarBD.Catalogo.Reinscripcion
{
    public partial class Reinscripcion : Form
    {
        ConexionBD conexion = new ConexionBD();
        private string txtConsultaObtener = "SELECT * FROM vwReinscripcionInformacion";
        public Reinscripcion()
        {
            InitializeComponent();
        }

        private void btnObtenerDatos_Click(object sender, EventArgs e)
        {
            dgvDatosReinscripcion.DataSource = conexion.ObtieneDatosBD(txtConsultaObtener);
        }

        private void btnAgregarNuevaVentana_Click(object sender, EventArgs e)
        {
            Modelos.Reinscripcion reinscripcion = new Modelos.Reinscripcion();

            Catalogo.Reinscripcion.AgregarEditar nuevaVentana = new Catalogo.Reinscripcion.AgregarEditar(reinscripcion);
            nuevaVentana.ShowDialog();

            if (reinscripcion.IDGrupo != null)
            {
                string[] nombres = { "IDGrupo", "IDAlumno", "Calificacion" };

                object[] valores = { reinscripcion.IDGrupo, reinscripcion.IDAlumno, reinscripcion.Calificacion };

                int renglonesfectados = conexion.InsertarDatosBD("stpReinscripcionInserta", nombres, valores);

                if (renglonesfectados >= 1)
                {
                    dgvDatosReinscripcion.DataSource = conexion.ObtieneDatosBD(txtConsultaObtener);
                }
            }
        }

        private void btnEditarNuevaVentana_Click(object sender, EventArgs e)
        {
            Modelos.Reinscripcion reinscripcion = new Modelos.Reinscripcion();
            int IDSeleccionado = 0;

            if (dgvDatosReinscripcion.SelectedRows != null && dgvDatosReinscripcion.SelectedRows.Count > 0)
            {
                IDSeleccionado = int.Parse(dgvDatosReinscripcion.SelectedRows[0].Cells[0].Value.ToString());
                DataGridViewRow r = dgvDatosReinscripcion.SelectedRows[0];
                reinscripcion.Calificacion = r.Cells["Calificacion"].Value.ToString();

            }
            else
            {
                MessageBox.Show("Debes seleccionar un registro.");
                return;
            }

            Catalogo.Reinscripcion.AgregarEditar nuevaVentana = new Catalogo.Reinscripcion.AgregarEditar(reinscripcion);
            nuevaVentana.ShowDialog();

            if (reinscripcion.IDGrupo != null)
            {
                string[] nombres = { "IDReinscripcion", "IDGrupo", "IDAlumno", "Calificacion" };

                object[] valores = { IDSeleccionado, reinscripcion.IDGrupo, reinscripcion.IDAlumno, reinscripcion.Calificacion };

                int renglonesfectados = conexion.EditarDatosBD("stpReinscripcionActualiza", nombres, valores);

                if (renglonesfectados >= 1)
                {
                    dgvDatosReinscripcion.DataSource = conexion.ObtieneDatosBD(txtConsultaObtener);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int IDSeleccionado = 0;
            if (dgvDatosReinscripcion.SelectedRows != null && dgvDatosReinscripcion.SelectedRows.Count > 0)
            {
                IDSeleccionado = int.Parse(dgvDatosReinscripcion.SelectedRows[0].Cells[0].Value.ToString());
            }
            else
            {
                MessageBox.Show("Debes seleccionar un registro.");
                return;
            }

            string nombre = "IDReinscripcion";
            object valor = IDSeleccionado;

            int renglonesfectados = conexion.EliminarDatosBD("stpReinscripcionElimina", nombre, valor);

            if (renglonesfectados >= 1)
            {
                dgvDatosReinscripcion.DataSource = conexion.ObtieneDatosBD(txtConsultaObtener);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
