using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ViewsDataTransfor.Models
{
    public class PersonPropertie
    {
        [Required(ErrorMessage = "Please enter FullName")]
        [DataType(DataType.Text)]
        [Display(Name = "Personfullname")]
        [MaxLength(100), MinLength(1)]
        public string PersonFullName { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Please enter Email ID")]
        [RegularExpression(@"^[0-9A-Za-z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z0-9]+[.][a-zA-Z]{2.3}([a-zA-Z]{2,3}){0,1}", ErrorMessage = "Email is not valid.")]
        public string PersonEmail { get; set; }
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "Please enter PhoneNumber")]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Please Enter Your Plan")]
        public string PersonPlan { get; set; }
        [Required(ErrorMessage = "Please enter Intervel"), MaxLength(30)]
        public Intervel PersonBillingIntervel { get; set; }
        [Required(ErrorMessage = "Please Enter Street address")]
        public string PersonStreetAddress { get; set; }
        [Required(ErrorMessage = "Please Enter City")]
        public City PersonCity { get; set; }
        [Required]
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "Please enter PhoneNumber")]
        [DataType(DataType.PhoneNumber)]
        public string PersonPhoneNumber { get; set; }

        [Required(ErrorMessage = "Please Enter state")]
        public State PersonState { get; set; }
        [Required(ErrorMessage = "Please Enter PinCode")]
        public string PersonPostalCode { get; set; }
        [Required(ErrorMessage = "Please Enter country")]
        public Country PersonCountry { get; set; }
        [Required(ErrorMessage = "Please Enter OldPassword")]
        public string PersonOldPassword { get; set; }
        [Required(ErrorMessage = "Please Ente NewPAssword")]
        public string PersonNewPassword { get; set; }

    }
}
