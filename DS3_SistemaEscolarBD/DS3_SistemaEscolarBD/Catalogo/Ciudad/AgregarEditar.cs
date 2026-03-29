using DS3_SistemaEscolarBD.Modelos;
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
    public partial class AgregarEditar : Form
    {
        Modelos.Ciudad ciudad = new Modelos.Ciudad();
        ConexionBD aconexion = new ConexionBD();
        public AgregarEditar(Modelos.Ciudad unaCiudad)
        {
            InitializeComponent();
            LlenarCombos();

            ciudad = unaCiudad;

            txtNombreCiudad.Text = ciudad.NombreCiudad;
            txtSiglasCiudad.Text = ciudad.SiglasCiudad;
        }
        public void LlenarCombos()
        {
            using (SqlConnection conexion = new SqlConnection(aconexion.txtConexion))
            {
                try
                {
                    DataTable dtEstado = new DataTable();
                    string consultaEstado = "SELECT [IDEstado],[NombreEstado] FROM [DS3_Catalogos].[dbo].[Estado]";

                    SqlDataAdapter adapter = new SqlDataAdapter(consultaEstado, conexion);
                    adapter.Fill(dtEstado);

                    cbEstado.DataSource = dtEstado;
                    cbEstado.DisplayMember = "NombreEstado";
                    cbEstado.ValueMember = "IDEstado";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Excepción al conectarse a la BD: " + ex.Message);
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ciudad.NombreCiudad = txtNombreCiudad.Text.ToString();
            ciudad.SiglasCiudad = txtSiglasCiudad.Text.ToString();
            ciudad.IDEstado = (int)cbEstado.SelectedValue;

            this.Close();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
