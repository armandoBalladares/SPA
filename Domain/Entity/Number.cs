using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Policy;

namespace SPA.Domain.Entity
{
    public class Number
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int Id { get; set; }
        public string Phone { get; set; }
        public int IdPerson { get; set; }
        public Person? Person { get; set; } 
        public  int IdOperator { get; set; }
        public  Operator? Operator { get; set; }
        public int IdTypeNumber { get; set; }
        public TypeNumber? TypeNumber { get; set; }
        public bool? Archived { get; set; } = false;

        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }
        public DateTime? Deleted { get; set; }
    }
}
