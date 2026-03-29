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

namespace DS3_SistemaEscolarBD.Catalogo.Reinscripcion
{
    public partial class AgregarEditar : Form
    {
        Modelos.Reinscripcion reinscripcion = new Modelos.Reinscripcion();
        ConexionBD aconexion = new ConexionBD();
        public AgregarEditar(Modelos.Reinscripcion unaReinscripcion)
        {
            InitializeComponent();
            LlenarCombos();

            reinscripcion = unaReinscripcion;

            txtCalificacion.Text = reinscripcion.Calificacion;
        }

        public void LlenarCombos()
        {
            using (SqlConnection conexion = new SqlConnection(aconexion.txtConexion))
            {
                try
                {
                    conexion.Open();
                    DataTable dtAlumno = new DataTable();
                    DataTable dtGrupo = new DataTable();
                    string consultaAlumno = "SELECT [IDAlumno],[Nombre] FROM [DS3_Catalogos].[dbo].[Alumno]";
                    string consultaGrupo = "SELECT [IDGrupo] FROM [DS3_Catalogos].[dbo].[Grupo]";

                    SqlDataAdapter adapter = new SqlDataAdapter(consultaAlumno, conexion);
                    adapter.Fill(dtAlumno);

                    SqlDataAdapter adapter2 = new SqlDataAdapter(consultaGrupo, conexion);
                    adapter2.Fill(dtGrupo);

                    cbAlumno.DataSource = dtAlumno;
                    cbAlumno.DisplayMember = "Nombre";
                    cbAlumno.ValueMember = "IDAlumno";

                    cbGrupo.DataSource = dtGrupo;
                    cbGrupo.DisplayMember = "IDGrupo";
                    cbGrupo.ValueMember = "IDGrupo";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Excepción al conectarse a la BD: " + ex.Message);
                }
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            reinscripcion.IDAlumno = (int)cbAlumno.SelectedValue;
            reinscripcion.IDGrupo = (int)cbGrupo.SelectedValue;
            reinscripcion.Calificacion = txtCalificacion.Text.ToString();

            this.Close();
        }
    }
}
