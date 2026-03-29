using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DS3_SistemaEscolarBD.Catalogo.Grupo
{
    public partial class Grupo : Form
    {
        ConexionBD conexion = new ConexionBD();
        private string txtConsultaObtener = "SELECT * FROM vwGrupoInformacion";

        public Grupo()
        {
            InitializeComponent();
        }

        private void btnAgregarNuevaVentana_Click(object sender, EventArgs e)
        {
            Modelos.Grupo grupo = new Modelos.Grupo();

            Catalogo.Grupo.AgregarEditar nuevaVentana = new Catalogo.Grupo.AgregarEditar(grupo);
            nuevaVentana.ShowDialog();

            if (grupo.Maestro != null)
            {
                string[] nombres = { "IDMaestro", "IDAula", "Horario", "IDCarrera", "IDMateria" };

                object[] valores = { grupo.Maestro, grupo.Aula, grupo.Horario, grupo.Carrera, grupo.Materia };

                int renglonesfectados = conexion.InsertarDatosBD("stpGrupoInserta", nombres, valores);

                if (renglonesfectados >= 1)
                {
                    dgvDatosGrupo.DataSource = conexion.ObtieneDatosBD(txtConsultaObtener);
                }
            }
        }

        private void btnEditarNuevaVentana_Click(object sender, EventArgs e)
        {
            Modelos.Grupo grupo = new Modelos.Grupo();
            int IDSeleccionado = 0;

            if (dgvDatosGrupo.SelectedRows != null && dgvDatosGrupo.SelectedRows.Count > 0)
            {
                IDSeleccionado = int.Parse(dgvDatosGrupo.SelectedRows[0].Cells[0].Value.ToString());
                DataGridViewRow r = dgvDatosGrupo.SelectedRows[0];
                grupo.Horario = r.Cells["Horario"].Value.ToString();

            }
            else
            {
                MessageBox.Show("Debes seleccionar un registro.");
                return;
            }

            Catalogo.Grupo.AgregarEditar nuevaVentana = new Catalogo.Grupo.AgregarEditar(grupo);
            nuevaVentana.ShowDialog();

            if (grupo.Maestro != null)
            {
                string[] nombres = { "IDGrupo", "IDMaestro", "IDAula", "Horario", "IDCarrera", "IDMateria" };

                object[] valores = { IDSeleccionado, grupo.Maestro, grupo.Aula, grupo.Horario, grupo.Carrera, grupo.Materia };

                int renglonesfectados = conexion.EditarDatosBD("stpGrupoActualiza", nombres, valores);

                if (renglonesfectados >= 1)
                {
                    dgvDatosGrupo.DataSource = conexion.ObtieneDatosBD(txtConsultaObtener);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int IDSeleccionado = 0;
            if (dgvDatosGrupo.SelectedRows != null && dgvDatosGrupo.SelectedRows.Count > 0)
            {
                IDSeleccionado = int.Parse(dgvDatosGrupo.SelectedRows[0].Cells[0].Value.ToString());
            }
            else
            {
                MessageBox.Show("Debes seleccionar un registro.");
                return;
            }

            string nombre = "IDGrupo";
            object valor = IDSeleccionado;

            int renglonesfectados = conexion.EliminarDatosBD("stpGrupoElimina", nombre, valor);

            if (renglonesfectados >= 1)
            {
                dgvDatosGrupo.DataSource = conexion.ObtieneDatosBD(txtConsultaObtener);
            }
        }

        private void btnObtenerDatos_Click(object sender, EventArgs e)
        {
            dgvDatosGrupo.DataSource = conexion.ObtieneDatosBD(txtConsultaObtener);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
