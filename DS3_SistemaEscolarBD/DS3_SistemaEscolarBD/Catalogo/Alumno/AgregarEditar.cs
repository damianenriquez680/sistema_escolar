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

namespace DS3_SistemaEscolarBD.Catalogo.Alumno
{
    public partial class AgregarEditar : Form
    {
        Modelos.Alumno alumno = new Modelos.Alumno();
        ConexionBD aconexion = new ConexionBD();
        public AgregarEditar(Modelos.Alumno unAlumno)
        {
            InitializeComponent();
            LlenarCombos();

            alumno = unAlumno;

            txtNombre.Text = alumno.NombreAlu;
            txtApellidos.Text = alumno.ApellidosAlu;
            cbEstatus.SelectedItem = alumno.EstatusAlu;
        }

        public void LlenarCombos()
        {
            using (SqlConnection conexion = new SqlConnection(aconexion.txtConexion))
            {
                try
                {
                    conexion.Open();
                    DataTable dtCarrera = new DataTable();
                    DataTable dtCiudad = new DataTable();
                    string consultaCarrera = "SELECT [IDCarrera],[NombreCarrera] FROM [DS3_Catalogos].[dbo].[Carrera]";
                    string consultaCiudad = "SELECT [IDCiudad],[NombreCiudad] FROM [DS3_Catalogos].[dbo].[Ciudad]";

                    SqlDataAdapter adapter = new SqlDataAdapter(consultaCarrera, conexion);
                    adapter.Fill(dtCarrera);

                    SqlDataAdapter adapter2 = new SqlDataAdapter(consultaCiudad, conexion);
                    adapter2.Fill(dtCiudad);

                    cbCarrera.DataSource = dtCarrera;
                    cbCarrera.DisplayMember = "NombreCarrera";
                    cbCarrera.ValueMember = "IDCarrera";

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
            alumno.NombreAlu = txtNombre.Text.ToString();
            alumno.ApellidosAlu = txtApellidos.Text.ToString();
            alumno.EstatusAlu = cbEstatus.SelectedItem.ToString();
            alumno.IDCarrera = (int)cbCarrera.SelectedValue;
            alumno.IDCiudad = (int)cbCiudad.SelectedValue;

            this.Close();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
