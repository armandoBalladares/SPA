using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SPA.Domain.Entity
{
    public class OrderDetails
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int Id { get; set; }
        public int IdOrder { get; set;}
        public Order? Order { get; set; }
        public int IdProduct { get; set; }
        public Product? Product { get; set; }
        public int Quantity { get; set; }
        public bool? Archived { get; set; } = false;
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }
        public DateTime? Deleted { get; set; }
    }
}
