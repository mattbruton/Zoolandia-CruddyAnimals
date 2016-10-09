using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ZoolandiaRazor.Models
{
    public class Animal
    {
        [Key]
        public int AnimalId { get; set; }
        [Required]
        public string Name { get; set; }
        public string CommonName { get; set; }
        public string ScientificName { get; set; }
        [Required]
        public Habitat CurrentHabitat { get; set; }
        public DateTime BirthDate { get; set; }

    }
}