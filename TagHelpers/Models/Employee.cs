using Microsoft.AspNetCore.Mvc.Rendering;
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
        public string FatherName { get; set; }
        public string Address { get; set; }
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 10)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public int Password { get; set; }
        [Required]
        [EmailAddress]
        public string EMail { get; set; }

        [Required]
        [Phone]
        public string Phone { get; set; }
        public SatesEnum Sates { get; set; }
        public  string Country { get; set; }

        public List<SelectListItem> Countries { get; } = new List<SelectListItem>
        {
            new SelectListItem{Value="",Text="--select--"},
            new SelectListItem { Value = "MX", Text = "Mexico" },
            new SelectListItem { Value = "CA", Text = "Canada" },
            new SelectListItem { Value = "US", Text = "USA"  },
        };
    }
    public enum SatesEnum
    {
        California,
        Florida,
        Texas,
        NewYark,
        Indiana
    }
}
