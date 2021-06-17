using LocationRepository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ViewsDataTransfor.Models
{
    public class PersonPropertie
    {
        [Required]
        [Display(Name ="FullName")]
        public string PersonFullName { get; set; }
        //[Required(ErrorMessage = "Please enter FullName")]
        //[DataType(DataType.Text)]
        //[Display(Name = "fullname")]
        //[MaxLength(100), MinLength(1)]
        //public string PersonFullName { get; set; }
        [DataType(DataType.EmailAddress)]
        [Display(Name = "EMail")]
        [Required(ErrorMessage = "Please enter Email ID")]
        [RegularExpression(@"^[0-9A-Za-z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z0-9]+[.][a-zA-Z]{2.3}([a-zA-Z]{2,3}){0,1}", ErrorMessage = "Email is not valid.")]
        public string PersonEmail { get; set; }
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "Please enter PhoneNumber")]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Please Enter Your Plan")]
        [Display(Name = "Plan")]
        public string PersonPlan { get; set; }
        [Required(ErrorMessage = "Please enter Intervel")]
        [Display(Name = "Intervel")]
        public Intervel PersonBillingIntervel { get; set; }
        [Required(ErrorMessage = "Please Enter Street address")]
        [Display(Name = "Address")]
        public string PersonStreetAddress { get; set; }
        [Required(ErrorMessage = "Please Enter City")]
        [Display(Name = "City")]
        public City PersonCity { get; set; }
        [Required]
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "Please enter PhoneNumber")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "PhoneNumber")]
        public string PersonPhoneNumber { get; set; }

        [Required(ErrorMessage = "Please Enter state")]
        [Display(Name = "State")]
        public State PersonState { get; set; }
        [Required(ErrorMessage = "Please Enter PinCode")]
        [Display(Name = "PostalCode")]
        public string PersonPostalCode { get; set; }
        [Required(ErrorMessage = "Please Enter country")]
        [Display(Name = "Country")]
        public Country PersonCountry { get; set; }
        [Required(ErrorMessage = "Please Enter OldPassword")]
        [Display(Name = "OldPassword")]
        public string PersonOldPassword { get; set; }
        [Required(ErrorMessage = "Please Ente NewPAssword")]
        [Display(Name = "NewPassword")]
        public string PersonNewPassword { get; set; }

    }
}
