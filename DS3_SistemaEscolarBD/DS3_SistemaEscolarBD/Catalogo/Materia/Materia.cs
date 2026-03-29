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

namespace DS3_SistemaEscolarBD.Catalogo.Materia
{
    public partial class Materia : Form
    {
        ConexionBD conexion = new ConexionBD();
        private string txtConsultaObtener = "SELECT * FROM vwMateriaInformacion";

        public Materia()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnObtenerDatos_Click(object sender, EventArgs e)
        {
            conexion = new ConexionBD();
            dgvDatosMateria.DataSource = conexion.ObtieneDatosBD(txtConsultaObtener);
        }

        private void btnAgregarNuevaVentana_Click(object sender, EventArgs e)
        {
            Modelos.Materia materia = new Modelos.Materia();

            Catalogo.Materia.AgregarEditar nuevaVentana = new Catalogo.Materia.AgregarEditar(materia);
            nuevaVentana.ShowDialog();

            if (materia.NombreMateria != null)
            {
                string[] nombres = { "NombreMateria", "Creditos" };

                object[] valores = { materia.NombreMateria, materia.Creditos };

                int renglonesfectados = conexion.InsertarDatosBD("stpMateriaInserta", nombres, valores);

                if (renglonesfectados >= 1)
                {
                    dgvDatosMateria.DataSource = conexion.ObtieneDatosBD(txtConsultaObtener);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int IDSeleccionado = 0;
            if (dgvDatosMateria.SelectedRows != null && dgvDatosMateria.SelectedRows.Count > 0)
            {
                IDSeleccionado = int.Parse(dgvDatosMateria.SelectedRows[0].Cells[0].Value.ToString());
            }
            else
            {
                MessageBox.Show("Debes seleccionar un registro.");
                return;
            }

            string nombre = "IDMateria";
            object valor = IDSeleccionado;

            int renglonesfectados = conexion.EliminarDatosBD("stpMateriaElimina", nombre, valor);

            if (renglonesfectados >= 1)
            {
                dgvDatosMateria.DataSource = conexion.ObtieneDatosBD(txtConsultaObtener);
            }
        }

        private void btnEditarNuevaVentana_Click(object sender, EventArgs e)
        {
            Modelos.Materia materia = new Modelos.Materia();
            int IDSeleccionado = 0;

            if (dgvDatosMateria.SelectedRows != null && dgvDatosMateria.SelectedRows.Count > 0)
            {
                IDSeleccionado = int.Parse(dgvDatosMateria.SelectedRows[0].Cells[0].Value.ToString());
                DataGridViewRow r = dgvDatosMateria.SelectedRows[0];
                materia.NombreMateria = r.Cells["Nombre"].Value.ToString();
                materia.Creditos = int.Parse(r.Cells["Creditos"].Value.ToString());
            }
            else
            {
                MessageBox.Show("Debes seleccionar un registro.");
                return;
            }

            Catalogo.Materia.AgregarEditar nuevaVentana = new Catalogo.Materia.AgregarEditar(materia);
            nuevaVentana.ShowDialog();

            if (materia.NombreMateria != null)
            {
                string[] nombres = { "IDMateria", "NombreMateria", "Creditos" };

                object[] valores = { IDSeleccionado, materia.NombreMateria, materia.Creditos };

                int renglonesfectados = conexion.EditarDatosBD("stpMateriaActualiza", nombres, valores);

                if (renglonesfectados >= 1)
                {
                    dgvDatosMateria.DataSource = conexion.ObtieneDatosBD(txtConsultaObtener);
                }
            }
        }
    }
}
