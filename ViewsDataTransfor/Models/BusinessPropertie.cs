using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ViewsDataTransfor.Models
{
    public class BusinessPropertie
    {
        
        [Required(ErrorMessage = "Please enter FullName")]
        [DataType(DataType.Text)]
        [Display(Name = "FullName")]
        [MaxLength(100), MinLength(1)]
        public string BusinessFullName { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Please enter Email ID")]
        [Display(Name = "EMail")]
        [RegularExpression(@"^[0-9A-Za-z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z0-9]+[.][a-zA-Z]{2.3}([a-zA-Z]{2,3}){0,1}", ErrorMessage = "Email is not valid.")]
        public string BusinessEmail { get; set; }
        //BusinessFullName
        [Required]
        [Display(Name = "PhoneNumber")]
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "Please enter PhoneNumber")]
        [DataType(DataType.PhoneNumber)]
        public string BusinessPhoneNumber { get; set; }
        [Required(ErrorMessage = "Please Enter Your Plan")]
        [Display(Name = "Plan")]
        public string BusinessPlan { get; set; }
        [Required(ErrorMessage = "Please enter Intervel")]
        [Display(Name = "Intervel")]
        public Intervel BusinessBillingIntervel { get; set; }
        [Required(ErrorMessage = "Please Enter Street address")]
        [Display(Name = "StreetAddress")]
        public string BusinessStreetAddress { get; set; }
        [Required(ErrorMessage = "Please Enter City")]
        [Display(Name = "City")]
        public City BusinessCity { get; set; }
        [Required(ErrorMessage = "Please Enter state")]
        [Display(Name = "State")]
        public State BusinessState { get; set; }
        [Required(ErrorMessage = "Please Enter PinCode")]
        [Display(Name = "PostalCode")]
        public string BusinessPostalCode { get; set; }
        [Required(ErrorMessage = "Please Enter country")]
        [Display(Name = "Country")]
        public Country BusinessCountry { get; set; }
        [Required(ErrorMessage = "Please Enter OldPassword")]
        [Display(Name = "OldPassword")]
        public string BusinessOldPassword { get; set; }
        [Required(ErrorMessage = "Please Ente NewPAssword")]
        [Display(Name = "NewPassword")]
        public string BusinessNewPassword { get; set; }

    }
}
