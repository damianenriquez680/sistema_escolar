using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS3_SistemaEscolarBD.Modelos
{
    public class Grupo
    {
        public int Alumno { get; set; }
        public int Maestro { get; set; }
        public int Aula { get; set; }
        public int Carrera { get; set; }
        public string Horario { get; set; }
        public int Materia { get; set; }

    }
}
