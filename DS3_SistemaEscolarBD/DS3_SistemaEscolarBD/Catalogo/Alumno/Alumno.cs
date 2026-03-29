using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DS3_SistemaEscolarBD.Catalogo.Alumno
{
    public partial class Alumno : Form
    {
        ConexionBD conexion = new ConexionBD();
        private string txtConsultaObtener = "SELECT * FROM vwAlumnoInformacion";

        public Alumno()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnObtenerDatos_Click(object sender, EventArgs e)
        {
            dgvDatosAlumno.DataSource = conexion.ObtieneDatosBD(txtConsultaObtener);
        }

        private void btnAgregarNuevaVentana_Click(object sender, EventArgs e)
        {
            Modelos.Alumno alumno = new Modelos.Alumno();

            Catalogo.Alumno.AgregarEditar nuevaVentana = new Catalogo.Alumno.AgregarEditar(alumno);
            nuevaVentana.ShowDialog();

            if (alumno.NombreAlu != null)
            {
                string[] nombres = { "Nombre", "Apellidos", "Estatus", "IDCarrera", "IDCiudad" };

                object[] valores = { alumno.NombreAlu, alumno.ApellidosAlu, alumno.EstatusAlu, alumno.IDCarrera, alumno.IDCiudad };

                int renglonesfectados = conexion.InsertarDatosBD("stpAlumnoInserta", nombres, valores);

                if (renglonesfectados >= 1)
                {
                    dgvDatosAlumno.DataSource = conexion.ObtieneDatosBD(txtConsultaObtener);
                }
            }
        }

        private void btnEditarNuevaVentana_Click(object sender, EventArgs e)
        {
            Modelos.Alumno alumno = new Modelos.Alumno();
            int IDSeleccionado = 0;

            if (dgvDatosAlumno.SelectedRows != null && dgvDatosAlumno.SelectedRows.Count > 0)
            {
                IDSeleccionado = int.Parse(dgvDatosAlumno.SelectedRows[0].Cells[0].Value.ToString());
                DataGridViewRow r = dgvDatosAlumno.SelectedRows[0];
                alumno.NombreAlu = r.Cells["Nombre"].Value.ToString();
                alumno.ApellidosAlu = r.Cells["Apellidos"].Value.ToString();
                alumno.EstatusAlu = r.Cells["Estatus"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Debes seleccionar un registro.");
                return;
            }

            Catalogo.Alumno.AgregarEditar nuevaVentana = new Catalogo.Alumno.AgregarEditar(alumno);
            nuevaVentana.ShowDialog();

            if (alumno.NombreAlu != null)
            {
                string[] nombres = { "IDAlumno", "Nombre", "Apellidos", "Estatus", "IDCarrera", "IDCiudad" };

                object[] valores = { IDSeleccionado, alumno.NombreAlu, alumno.ApellidosAlu, alumno.EstatusAlu, alumno.IDCarrera, alumno.IDCiudad };

                int renglonesfectados = conexion.EditarDatosBD("stpAlumnoActualiza", nombres, valores);

                if (renglonesfectados >= 1)
                {
                    dgvDatosAlumno.DataSource = conexion.ObtieneDatosBD(txtConsultaObtener);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int IDSeleccionado = 0;
            if (dgvDatosAlumno.SelectedRows != null && dgvDatosAlumno.SelectedRows.Count > 0)
            {
                IDSeleccionado = int.Parse(dgvDatosAlumno.SelectedRows[0].Cells[0].Value.ToString());
            }
            else
            {
                MessageBox.Show("Debes seleccionar un registro.");
                return;
            }

            string nombre = "IDAlumno";
            object valor = IDSeleccionado;

            int renglonesfectados = conexion.EliminarDatosBD("stpAlumnoElimina", nombre, valor);

            if (renglonesfectados >= 1)
            {
                dgvDatosAlumno.DataSource = conexion.ObtieneDatosBD(txtConsultaObtener);
            }
        }
    }
}
