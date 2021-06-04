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
        //@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$"
        [RegularExpression(@"^[0-9A-Za-z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z0-9]+[.][a-zA-Z]{2.3}([a-zA-Z]{2,3}){0,1}", ErrorMessage = "Email is not valid.")]
        public string PersonEmail { get; set; }

        [Required]
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "Please enter PhoneNumber")]
        [DataType(DataType.PhoneNumber)]
        public string PersonPhoneNumber { get; set; }
        [Required(ErrorMessage = "Please Enter Your Plan")]
        public string PersonPlan { get; set; }
        [Required(ErrorMessage = "Please enter Intervel"), MaxLength(30)]
        public string PersonBillingIntervel { get; set; }
        [Required(ErrorMessage = "Please Enter Street address")]
        public string PersonStreetAddress { get; set; }
        [Required(ErrorMessage = "Please Enter City")]
        public string PersonCity { get; set; }
        [Required(ErrorMessage = "Please Enter state")]
        public string PersonState { get; set; }
        [Required(ErrorMessage = "Please Enter PinCode")]
        public string PersonPostalCode { get; set; }
        [Required(ErrorMessage = "Please Enter country")] public string PersonCountry { get; set; }
        [Required(ErrorMessage = "Please Enter OldPassword")] public string PersonOldPassword { get; set; }
        [Required(ErrorMessage = "Please Ente NewPAssword")]
        // [Compare(nameof(OldPassword), ErrorMessage = "Passwords don't match.")]
        public string PersonNewPassword { get; set; }

    }
}
