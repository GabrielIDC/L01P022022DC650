using System.ComponentModel.DataAnnotations;
namespace L01P022022DC650.Models
{
    public class materias
    {
        [Key]
        public int id { get; set; }
        public string materia { get; set; }
        public string unidades_valorativas { get; set; }
        public char estado { get; set; }
    }
}
