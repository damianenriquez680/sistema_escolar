using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DS3_SistemaEscolarBD.Catalogo.Pais
{
    public partial class Pais : Form
    {
        ConexionBD conexion = new ConexionBD();
        private string txtConsultaObtener = "SELECT * FROM vwPaisInformacion";
        public Pais()
        {
            InitializeComponent();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnObtenerDatos_Click(object sender, EventArgs e)
        {
            dgvDatosPais.DataSource = conexion.ObtieneDatosBD(txtConsultaObtener);
        }

        private void btnAgregarNuevaVentana_Click(object sender, EventArgs e)
        {
            Modelos.Pais pais = new Modelos.Pais();

            Catalogo.Pais.AgregarEditar nuevaVentana = new Catalogo.Pais.AgregarEditar(pais);
            nuevaVentana.ShowDialog();

            if (pais.NombrePais != null)
            {
                string[] nombres = { "NombrePais", "SiglaPais" };

                object[] valores = { pais.NombrePais, pais.SiglaPais };

                int renglonesfectados = conexion.InsertarDatosBD("stpPaisInserta", nombres, valores);

                if (renglonesfectados >= 1)
                {
                    dgvDatosPais.DataSource = conexion.ObtieneDatosBD(txtConsultaObtener);
                }
            }
        }

        private void btnEditarNuevaVentana_Click(object sender, EventArgs e)
        {
            Modelos.Pais pais = new Modelos.Pais();
            int IDSeleccionado = 0;

            if (dgvDatosPais.SelectedRows != null && dgvDatosPais.SelectedRows.Count > 0)
            {
                IDSeleccionado = int.Parse(dgvDatosPais.SelectedRows[0].Cells[0].Value.ToString());
                DataGridViewRow r = dgvDatosPais.SelectedRows[0];
                pais.NombrePais = r.Cells["Nombre"].Value.ToString();
                pais.SiglaPais = r.Cells["Siglas"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Debes seleccionar un registro.");
                return;
            }

            Catalogo.Pais.AgregarEditar nuevaVentana = new Catalogo.Pais.AgregarEditar(pais);
            nuevaVentana.ShowDialog();

            if (pais.NombrePais != null)
            {
                string[] nombres = { "IDPais", "NombrePais", "SiglaPais" };

                object[] valores = { IDSeleccionado, pais.NombrePais, pais.SiglaPais };

                int renglonesfectados = conexion.EditarDatosBD("stpPaisActualiza", nombres, valores);

                if (renglonesfectados >= 1)
                {
                    dgvDatosPais.DataSource = conexion.ObtieneDatosBD(txtConsultaObtener);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int IDSeleccionado = 0;
            if (dgvDatosPais.SelectedRows != null && dgvDatosPais.SelectedRows.Count > 0)
            {
                IDSeleccionado = int.Parse(dgvDatosPais.SelectedRows[0].Cells[0].Value.ToString());
            }
            else
            {
                MessageBox.Show("Debes seleccionar un registro.");
                return;
            }

            string nombre = "IDPais";
            object valor = IDSeleccionado;

            int renglonesfectados = conexion.EliminarDatosBD("stpPaisElimina", nombre, valor);

            if (renglonesfectados >= 1)
            {
                dgvDatosPais.DataSource = conexion.ObtieneDatosBD(txtConsultaObtener);
            }
        }
    }
}
