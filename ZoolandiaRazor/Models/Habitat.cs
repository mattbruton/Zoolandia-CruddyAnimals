using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZoolandiaRazor.Models
{
    public class Habitat
    {
        [Key]
        public int HabitatId { get; set; }

        [Required]
        public string HabitatName { get; set; }

        public string HabitatType { get; set; }
        public List<Animal> AnimalList { get; set; }
        public List<Employee> EmployeeList { get; set; }
    }
}