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

namespace DS3_SistemaEscolarBD.Catalogo.Grupo
{
    public partial class AgregarEditar : Form
    {
        Modelos.Grupo grupo = new Modelos.Grupo();
        ConexionBD aconexion = new ConexionBD();
        public AgregarEditar(Modelos.Grupo unGrupo)
        {
            InitializeComponent();
            LlenarCombos();

            grupo = unGrupo;

            cbHorario.SelectedItem = grupo.Horario;
        }

        public void LlenarCombos()
        {
            using (SqlConnection conexion = new SqlConnection(aconexion.txtConexion))
            {
                try
                {
                    conexion.Open();
                    DataTable dtAlumno = new DataTable();
                    DataTable dtMaestro = new DataTable();
                    DataTable dtAula = new DataTable();
                    DataTable dtCarrera = new DataTable();
                    DataTable dtMateria = new DataTable();
                    string consultaAlumno = "SELECT [IDAlumno],[Nombre] FROM [DS3_Catalogos].[dbo].[Alumno]";
                    string consultaMaestro = "SELECT [IDAcademico],[Nombre] FROM [DS3_Catalogos].[dbo].[Academico]";
                    string consultaAula = "SELECT [IDAula],[NombreAula] FROM [DS3_Catalogos].[dbo].[Aula]";
                    string consultaCarrera = "SELECT [IDCarrera],[NombreCarrera] FROM [DS3_Catalogos].[dbo].[Carrera]";
                    string consultaMateria = "SELECT [IDMateria],[NombreMateria] FROM [DS3_Catalogos].[dbo].[Materia]";

                    SqlDataAdapter adapter = new SqlDataAdapter(consultaAlumno, conexion);
                    adapter.Fill(dtAlumno);

                    SqlDataAdapter adapter2 = new SqlDataAdapter(consultaMaestro, conexion);
                    adapter2.Fill(dtMaestro);

                    SqlDataAdapter adapter3 = new SqlDataAdapter(consultaAula, conexion);
                    adapter3.Fill(dtAula);

                    SqlDataAdapter adapter4 = new SqlDataAdapter(consultaCarrera, conexion);
                    adapter4.Fill(dtCarrera);

                    SqlDataAdapter adapter5 = new SqlDataAdapter(consultaMateria, conexion);
                    adapter5.Fill(dtMateria);

                    cbAlumno.DataSource = dtAlumno;
                    cbAlumno.DisplayMember = "Nombre";
                    cbAlumno.ValueMember = "IDAlumno";

                    cbMaestro.DataSource = dtMaestro;
                    cbMaestro.DisplayMember = "Nombre";
                    cbMaestro.ValueMember = "IDAcademico";

                    cbAula.DataSource = dtAula;
                    cbAula.DisplayMember = "NombreAula";
                    cbAula.ValueMember = "IDAula";

                    cbCarrera.DataSource = dtCarrera;
                    cbCarrera.DisplayMember = "NombreCarrera";
                    cbCarrera.ValueMember = "IDCarrera";

                    cbMateria.DataSource = dtMateria;
                    cbMateria.DisplayMember = "NombreMateria";
                    cbMateria.ValueMember = "IDMateria";
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
            grupo.Alumno = (int)cbAlumno.SelectedValue;
            grupo.Maestro = (int)cbMaestro.SelectedValue;
            grupo.Aula = (int)cbAula.SelectedValue;
            grupo.Horario = cbHorario.SelectedItem.ToString();
            grupo.Carrera = (int)cbCarrera.SelectedValue;
            grupo.Materia = (int)cbMateria.SelectedValue;

            this.Close();
        }
    }
}
