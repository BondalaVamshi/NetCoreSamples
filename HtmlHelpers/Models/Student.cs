using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HtmlHelpers.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        [Display(Name = "Name")]
        public string StudentName { get; set; }
        public string FatherName { get; set; }
        public int Age { get; set; }
        public string Description { get; set; }
        public bool isNewlyEnrolled { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
    }
}
