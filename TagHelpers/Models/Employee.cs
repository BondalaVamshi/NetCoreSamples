using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TagHelpers.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name {get; set; }

        [Required]
        public string Location { get; set; }
        public string Job { get; }
        public string Address { get; set; }
    }
}
