using System.ComponentModel.DataAnnotations;

namespace SCAF.Models
{
    public class Alumno
    {
        [Key]
        public int IdAlumno { get; set; }
        public string Carnet { get; set; }
        public string NombreCompleto { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string NivelActual { get; set; }
        public string AnioLectivo { get; set; }

    }
}
