﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SPA.Domain.Entity
{
    public class Person
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public string DNI { get; set; }
        public string Email { get; set; }
        public ICollection<Address>? Addresses { get; set; }
        public ICollection<Number>? Numbers { get; set; }
        public bool? Archived { get; set; } = false;

        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }
        public DateTime? Deleted { get; set; }

    }
}
