using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS3_SistemaEscolarBD.Modelos
{
    public class Alumno
    {
        public string NombreAlu { get; set; }
        public string ApellidosAlu { get; set; }
        public string EstatusAlu { get; set; }
        public int IDCarrera { get; set; }
        public int IDCiudad { get; set; }
    }
}
