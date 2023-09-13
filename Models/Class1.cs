using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Practica3_PrograWeb.Models
{
    public class Class1
    {
        [Key]
        public int Class1Id { get; set; }

        public string Name { get; set; }

        // Relación con Class2
        public int Class2Id { get; set; }
        [ForeignKey("Class2Id")]
        public Class2 RelatedClass2 { get; set; }

        // Relación con Class3
        public int Class3Id { get; set; }
        [ForeignKey("Class3Id")]
        public Class3 RelatedClass3 { get; set; }
    }
}
