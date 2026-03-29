using DS3_SistemaEscolarBD.Modelos;
using Microsoft.Data.SqlClient;
using System.Data;

namespace DS3_SistemaEscolarBD
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMateria_Click(object sender, EventArgs e)
        {
            Catalogo.Materia.Materia Materia = new Catalogo.Materia.Materia();
            Materia.ShowDialog();
        }

        private void btnAcademico_Click(object sender, EventArgs e)
        {
            Catalogo.Academico.Academico academico = new Catalogo.Academico.Academico();
            academico.ShowDialog();
        }

        private void btnAula_Click(object sender, EventArgs e)
        {
            Catalogo.Aula.Aula aula = new Catalogo.Aula.Aula();
            aula.ShowDialog();
        }

        private void btnAlumno_Click(object sender, EventArgs e)
        {
            Catalogo.Alumno.Alumno alumno = new Catalogo.Alumno.Alumno();
            alumno.ShowDialog();
        }

        private void btnCarrera_Click(object sender, EventArgs e)
        {
            Catalogo.Carrera.Carrera carrera = new Catalogo.Carrera.Carrera();
            carrera.ShowDialog();
        }

        private void btnCiudad_Click(object sender, EventArgs e)
        {
            Catalogo.Ciudad.Ciudad ciudad = new Catalogo.Ciudad.Ciudad();
            ciudad.ShowDialog();
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            Catalogo.Estado.Estado Estado = new Catalogo.Estado.Estado();
            Estado.ShowDialog();
        }

        private void btnPais_Click_1(object sender, EventArgs e)
        {
            Catalogo.Pais.Pais pais = new Catalogo.Pais.Pais();
            pais.ShowDialog();
        }

        private void btnEstatus_Click(object sender, EventArgs e)
        {
            Catalogo.Estatus.Estatus estatus = new Catalogo.Estatus.Estatus();
            estatus.ShowDialog();
        }

        private void btnGrupo_Click(object sender, EventArgs e)
        {
            Catalogo.Grupo.Grupo grupo = new Catalogo.Grupo.Grupo();
            grupo.ShowDialog();
        }

        private void btnReinscripción_Click(object sender, EventArgs e)
        {
            Catalogo.Reinscripcion.Reinscripcion reincripcion = new Catalogo.Reinscripcion.Reinscripcion();
            reincripcion.ShowDialog();
        }
    }
}
