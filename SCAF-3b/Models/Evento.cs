using System.ComponentModel.DataAnnotations;

namespace SCAF.Models
{
    public class Evento
    {
        [Key]
        public int IdEvento { get; set; }
        public string NombreEvento { get; set; }
        public DateTime Fecha { get; set; }
        public string Lugar { get; set; }
        public string Descripcion { get; set; }
    }
}
