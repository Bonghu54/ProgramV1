using System.ComponentModel.DataAnnotations;

namespace Practica3_PrograWeb.Models
{
    public class Class2
    {
        [Key]
        public int Class2Id { get; set; }

        public string Description { get; set; }

        // Relación con Class1
        public ICollection<Class1> RelatedClass1s { get; set; }
    }
}
