using System.ComponentModel.DataAnnotations;

namespace Practica3_PrograWeb.Models
{
    public class Class3
    {
        [Key]
        public int Class3Id { get; set; }

        public string SomeProperty { get; set; }

        // Relación con Class1
        public ICollection<Class1> RelatedClass1s { get; set; }
    }
}
