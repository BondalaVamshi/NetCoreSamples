using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessFormTask.Models
{
    public class BusinessPropertie
    {
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Please enter Email ID")]
        //@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$"
        [RegularExpression(@"^[0-9A-Za-z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z0-9]+[.][a-zA-Z]{2.3}([a-zA-Z]{2,3}){0,1}", ErrorMessage = "Email is not valid.")]
        public string BusinessEmail { get; set; }

        [Required]
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "Please enter PhoneNumber")]
        [DataType(DataType.PhoneNumber)]
        public string BusinessPhoneNumber { get; set; }
        [Required(ErrorMessage = "Please Enter Your Plan")]
        public string BusinessPlan { get; set; }
        [Required(ErrorMessage = "Please enter Intervel"), MaxLength(30)]
        public string BusinessBillingIntervel { get; set; }
        [Required(ErrorMessage = "Please Enter Street address")]
        public string BusinessStreetAddress { get; set; }
        [Required(ErrorMessage = "Please Enter City")]
        public string BusinessCity { get; set; }
        [Required(ErrorMessage = "Please Enter state")]
        public string BusinessState { get; set; }
        [Required(ErrorMessage = "Please Enter PinCode")]
        public string BusinessPostalCode { get; set; }
        [Required(ErrorMessage = "Please Enter country")]
        public string BusinessCountry { get; set; }
        [Required(ErrorMessage = "Please Enter OldPassword")]
        public string BusinessOldPassword { get; set; }
        [Required(ErrorMessage = "Please Ente NewPAssword")]
        // [Compare(nameof(OldPassword), ErrorMessage = "Passwords don't match.")]
        public string BusinessNewPassword { get; set; }

    }
}
