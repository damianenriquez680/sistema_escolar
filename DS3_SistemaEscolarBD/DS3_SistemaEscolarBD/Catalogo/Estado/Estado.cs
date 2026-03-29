using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DS3_SistemaEscolarBD.Catalogo.Estado
{
    public partial class Estado : Form
    {
        ConexionBD conexion = new ConexionBD();
        private string txtConsultaObtener = "SELECT * FROM vwEstadoInformacion";
        public Estado()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnObtenerDatos_Click(object sender, EventArgs e)
        {
            dgvDatosEstado.DataSource = conexion.ObtieneDatosBD(txtConsultaObtener);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int IDSeleccionado = 0;
            if (dgvDatosEstado.SelectedRows != null && dgvDatosEstado.SelectedRows.Count > 0)
            {
                IDSeleccionado = int.Parse(dgvDatosEstado.SelectedRows[0].Cells[0].Value.ToString());
            }
            else
            {
                MessageBox.Show("Debes seleccionar un registro.");
                return;
            }

            string nombre = "IDEstado";
            object valor = IDSeleccionado;

            int renglonesfectados = conexion.EliminarDatosBD("stpEstadoElimina", nombre, valor);

            if (renglonesfectados >= 1)
            {
                dgvDatosEstado.DataSource = conexion.ObtieneDatosBD(txtConsultaObtener);
            }
        }

        private void btnAgregarNuevaVentana_Click(object sender, EventArgs e)
        {
            Modelos.Estado estado = new Modelos.Estado();

            Catalogo.Estado.AgregarEditar nuevaVentana = new Catalogo.Estado.AgregarEditar(estado);
            nuevaVentana.ShowDialog();

            if (estado.NombreEstado != null)
            {
                string[] nombres = { "NombreEstado", "SiglaEstado", "IDPais" };

                object[] valores = { estado.NombreEstado, estado.SiglaEstado, estado.IDPais };

                int renglonesfectados = conexion.InsertarDatosBD("stpEstadoInserta", nombres, valores);

                if (renglonesfectados >= 1)
                {
                    dgvDatosEstado.DataSource = conexion.ObtieneDatosBD(txtConsultaObtener);
                }
            }
        }

        private void btnEditarNuevaVentana_Click(object sender, EventArgs e)
        {
            Modelos.Estado estado = new Modelos.Estado();
            int IDSeleccionado = 0;

            if (dgvDatosEstado.SelectedRows != null && dgvDatosEstado.SelectedRows.Count > 0)
            {
                IDSeleccionado = int.Parse(dgvDatosEstado.SelectedRows[0].Cells[0].Value.ToString());
                DataGridViewRow r = dgvDatosEstado.SelectedRows[0];
                estado.NombreEstado = r.Cells["Nombre"].Value.ToString();
                estado.SiglaEstado = r.Cells["Siglas"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Debes seleccionar un registro.");
                return;
            }

            Catalogo.Estado.AgregarEditar nuevaVentana = new Catalogo.Estado.AgregarEditar(estado);
            nuevaVentana.ShowDialog();

            if (estado.NombreEstado != null)
            {
                string[] nombres = { "IDEstado", "NombreEstado", "SiglaEstado", "IDPais" };

                object[] valores = { IDSeleccionado, estado.NombreEstado, estado.SiglaEstado, estado.IDPais };

                int renglonesfectados = conexion.EditarDatosBD("stpEstadoActualiza", nombres, valores);

                if (renglonesfectados >= 1)
                {
                    dgvDatosEstado.DataSource = conexion.ObtieneDatosBD(txtConsultaObtener);
                }
            }
        }
    }
}
