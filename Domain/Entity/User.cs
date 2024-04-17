using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SPA.Domain.Entity
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int IdPerson { get; set; }
        public Person? Person { get; set; }
        public bool? Archived { get; set; } = false;

        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }
        public DateTime? Deleted
        {
            get; set;

        }
    }
}
