using DS3_SistemaEscolarBD.Catalogo.Ciudad;
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

namespace DS3_SistemaEscolarBD.Catalogo.Estado
{
    public partial class AgregarEditar : Form
    {
        Modelos.Estado estado = new Modelos.Estado();
        ConexionBD aconexion = new ConexionBD();
        public AgregarEditar(Modelos.Estado unEstado)
        {
            InitializeComponent();
            LlenarCombos();

            estado = unEstado;

            txtNombreEstado.Text = estado.NombreEstado;
            txtSiglasEstado.Text = estado.SiglaEstado;
        }
        public void LlenarCombos()
        {
            using (SqlConnection conexion = new SqlConnection(aconexion.txtConexion))
            {
                try
                {
                    DataTable dtPais = new DataTable();
                    string consultaPais = "SELECT [IDPais],[NombrePais] FROM [DS3_Catalogos].[dbo].[Pais]";

                    SqlDataAdapter adapter = new SqlDataAdapter(consultaPais, conexion);
                    adapter.Fill(dtPais);

                    cbPais.DataSource = dtPais;
                    cbPais.DisplayMember = "NombrePais";
                    cbPais.ValueMember = "IDPais";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Excepción al conectarse a la BD: " + ex.Message);
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            estado.NombreEstado = txtNombreEstado.Text.ToString();
            estado.SiglaEstado = txtSiglasEstado.Text.ToString();
            estado.IDPais = (int)cbPais.SelectedValue;

            this.Close();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
