using System.ComponentModel.DataAnnotations;

namespace SCAF.Models
{
    public class Asistencia
    {
        [Key]
        public int IdAsistencia { get; set; }
        public int IdEvento { get; set; }
        public int IdPadre { get; set; }
        public int IdAlumno { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Estado { get; set; }
    }
}
