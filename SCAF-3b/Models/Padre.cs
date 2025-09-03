using System.ComponentModel.DataAnnotations;

namespace SCAF.Models
{
    public class Padre
    {
        [Key]
        public int IdPadre { get; set; }
        public string NombreCompleto { get; set; }
        public string DocumentoIdentidad { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
    }
}
