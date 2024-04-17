using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SPA.Domain.Entity
{
    public class Production
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int Id { get; set; }
        public int IdProduct {get; set;}
        public Product? Product { get; set;}
        public int Quantity { get; set; }
        public DateTime ProductionDate { get; set; }
        public bool? Archived { get; set; } = false;
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }
        public DateTime? Deleted { get; set; }
    }
}
