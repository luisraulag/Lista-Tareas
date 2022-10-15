using MessagePack;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;


namespace ListaDeTareasRefresquera.Models
{
    public class Tarea
    {
        [Key]
        public int IdTarea { get; set; }

        public string NombreTarea { get; set; }
        public string FechaTarea { get; set; }
        public bool EstatusTarea { get; set; }

    }
}
