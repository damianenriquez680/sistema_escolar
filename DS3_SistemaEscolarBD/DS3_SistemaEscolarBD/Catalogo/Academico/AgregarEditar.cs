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

namespace DS3_SistemaEscolarBD.Catalogo.Academico
{
    public partial class AgregarEditar : Form
    {
        Modelos.Academico academico = new Modelos.Academico();
        ConexionBD aconexion = new ConexionBD();

        public AgregarEditar(Modelos.Academico unAcademico)
        {
            InitializeComponent();
            LlenarCombos();

            academico = unAcademico;

            txtNombre.Text = academico.Nombre;
            txtApellidos.Text = academico.Apellidos;
            txtGrado.Text = academico.Grado;
        }

        public void LlenarCombos()
        {
            using (SqlConnection conexion = new SqlConnection(aconexion.txtConexion))
            {
                try
                {
                    conexion.Open();
                    DataTable dtCiudad = new DataTable();
                    string consultaCiudad = "SELECT [IDCiudad],[NombreCiudad] FROM [DS3_Catalogos].[dbo].[Ciudad]";

                    SqlDataAdapter adapter = new SqlDataAdapter(consultaCiudad, conexion);
                    adapter.Fill(dtCiudad);

                    cbCiudad.DataSource = dtCiudad;
                    cbCiudad.DisplayMember = "NombreCiudad";
                    cbCiudad.ValueMember = "IDCiudad";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Excepción al conectarse a la BD: " + ex.Message);
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            academico.Nombre = txtNombre.Text.ToString();
            academico.Apellidos = txtApellidos.Text.ToString();
            academico.Grado = txtGrado.Text.ToString();
            academico.IDCiudad = (int)cbCiudad.SelectedValue;

            this.Close();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
