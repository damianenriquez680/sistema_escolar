using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DS3_SistemaEscolarBD.Catalogo.Aula
{
    public partial class Aula : Form
    {
        ConexionBD conexion = new ConexionBD();
        private string txtConsultaObtener = "SELECT * FROM vwAulaInformacion";

        public Aula()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnObtenerDatos_Click(object sender, EventArgs e)
        {
            dgvDatosAula.DataSource = conexion.ObtieneDatosBD(txtConsultaObtener);
        }

        private void btnAgregarNuevaVentana_Click(object sender, EventArgs e)
        {
            Modelos.Aula aula = new Modelos.Aula();

            Catalogo.Aula.AgregarEditar nuevaVentana = new Catalogo.Aula.AgregarEditar(aula);
            nuevaVentana.ShowDialog();

            if (aula.NombreAula != null)
            {
                string[] nombres = { "Edificio", "NombreAula", "Piso", "CapacidadMaxima" };

                object[] valores = { aula.Edificio, aula.NombreAula, aula.Piso, aula.CapaMax };

                int renglonesfectados = conexion.InsertarDatosBD("stpAulaInserta", nombres, valores);

                if (renglonesfectados >= 1)
                {
                    dgvDatosAula.DataSource = conexion.ObtieneDatosBD(txtConsultaObtener);
                }
            }
        }

        private void btnEditarNuevaVentana_Click(object sender, EventArgs e)
        {
            Modelos.Aula aula = new Modelos.Aula();
            int IDSeleccionado = 0;

            if (dgvDatosAula.SelectedRows != null && dgvDatosAula.SelectedRows.Count > 0)
            {
                IDSeleccionado = int.Parse(dgvDatosAula.SelectedRows[0].Cells[0].Value.ToString());
                DataGridViewRow r = dgvDatosAula.SelectedRows[0];
                aula.Edificio = r.Cells["Edificio"].Value.ToString();
                aula.NombreAula = r.Cells["Nombre"].Value.ToString();
                aula.Piso = r.Cells["Piso"].Value.ToString();
                aula.CapaMax = int.Parse(r.Cells["Capacidad máxima"].Value.ToString());
            }
            else
            {
                MessageBox.Show("Debes seleccionar un registro.");
                return;
            }

            Catalogo.Aula.AgregarEditar nuevaVentana = new Catalogo.Aula.AgregarEditar(aula);
            nuevaVentana.ShowDialog();

            if (aula.NombreAula != null)
            {
                string[] nombres = { "IDAula", "Edificio", "NombreAula", "Piso", "CapacidadMaxima" };

                object[] valores = { IDSeleccionado, aula.Edificio, aula.NombreAula, aula.Piso, aula.CapaMax };

                int renglonesfectados = conexion.EditarDatosBD("stpAulaActualiza", nombres, valores);

                if (renglonesfectados >= 1)
                {
                    dgvDatosAula.DataSource = conexion.ObtieneDatosBD(txtConsultaObtener);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int IDSeleccionado = 0;
            if (dgvDatosAula.SelectedRows != null && dgvDatosAula.SelectedRows.Count > 0)
            {
                IDSeleccionado = int.Parse(dgvDatosAula.SelectedRows[0].Cells[0].Value.ToString());
            }
            else
            {
                MessageBox.Show("Debes seleccionar un registro.");
                return;
            }

            string nombre = "IDAula";
            object valor = IDSeleccionado;

            int renglonesfectados = conexion.EliminarDatosBD("stpAulaElimina", nombre, valor);

            if (renglonesfectados >= 1)
            {
                dgvDatosAula.DataSource = conexion.ObtieneDatosBD(txtConsultaObtener);
            }
        }
    }
}
