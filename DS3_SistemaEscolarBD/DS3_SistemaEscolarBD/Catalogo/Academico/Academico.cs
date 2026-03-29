using DS3_SistemaEscolarBD.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DS3_SistemaEscolarBD.Catalogo.Academico
{
    public partial class Academico : Form
    {
        ConexionBD conexion = new ConexionBD();
        private string txtConsultaObtener = "SELECT * FROM vwAcademicoInformacion";

        public Academico()
        {
            InitializeComponent();
        }

        private void btnObtenerDatos_Click(object sender, EventArgs e)
        {
            dgvDatosAcademico.DataSource = conexion.ObtieneDatosBD(txtConsultaObtener);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarNuevaVentana_Click(object sender, EventArgs e)
        {
            Modelos.Academico academico = new Modelos.Academico();

            Catalogo.Academico.AgregarEditar nuevaVentana = new Catalogo.Academico.AgregarEditar(academico);
            nuevaVentana.ShowDialog();

            if (academico.Nombre != null)
            {
                string[] nombres = { "Nombre", "Apellidos", "Grado", "IDCiudad" };

                object[] valores = { academico.Nombre, academico.Apellidos, academico.Grado, academico.IDCiudad };

                string[] salida = { "Regreso", "Mensaje" };

                int renglonesfectados = conexion.InsertarDatosBD("stpAcademicoInserta", nombres, valores);

                if (renglonesfectados >= 1)
                {
                    dgvDatosAcademico.DataSource = conexion.ObtieneDatosBD(txtConsultaObtener);
                }
            }
        }

        private void btnEditarNuevaVentana_Click(object sender, EventArgs e)
        {
            Modelos.Academico academico = new Modelos.Academico();
            int IDSeleccionado = 0;

            if (dgvDatosAcademico.SelectedRows != null && dgvDatosAcademico.SelectedRows.Count > 0)
            {
                IDSeleccionado = int.Parse(dgvDatosAcademico.SelectedRows[0].Cells[0].Value.ToString());
                DataGridViewRow r = dgvDatosAcademico.SelectedRows[0];
                academico.Nombre = r.Cells["Nombre"].Value.ToString();
                academico.Apellidos = r.Cells["Apellidos"].Value.ToString();
                academico.Grado = r.Cells["Grado"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Debes seleccionar un registro.");
                return;
            }

            Catalogo.Academico.AgregarEditar nuevaVentana = new Catalogo.Academico.AgregarEditar(academico);
            nuevaVentana.ShowDialog();

            if (academico.Nombre != null)
            {
                string[] nombres = { "IDAcademico", "Nombre", "Apellidos", "Grado", "IDCiudad" };

                object[] valores = { IDSeleccionado, academico.Nombre, academico.Apellidos, academico.Grado, academico.IDCiudad };

                int renglonesfectados = conexion.EditarDatosBD("stpAcademicoActualiza", nombres, valores);

                if (renglonesfectados >= 1)
                {
                    dgvDatosAcademico.DataSource = conexion.ObtieneDatosBD(txtConsultaObtener);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int IDSeleccionado = 0;
            if (dgvDatosAcademico.SelectedRows != null && dgvDatosAcademico.SelectedRows.Count > 0)
            {
                IDSeleccionado = int.Parse(dgvDatosAcademico.SelectedRows[0].Cells[0].Value.ToString());
            }
            else
            {
                MessageBox.Show("Debes seleccionar un registro.");
                return;
            }

            string nombre = "IDAcademico"; 
            object valor = IDSeleccionado;

            int renglonesfectados = conexion.EliminarDatosBD("stpAcademicoElimina", nombre, valor);

            if (renglonesfectados >= 1)
            {
                dgvDatosAcademico.DataSource = conexion.ObtieneDatosBD(txtConsultaObtener);
            }
        }
    }
}
