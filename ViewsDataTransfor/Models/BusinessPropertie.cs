﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ViewsDataTransfor.Models
{
    public class BusinessPropertie
    {
        [Required(ErrorMessage ="Please enter")]
        public string TestValid { get; set; }
        [Required(ErrorMessage = "Please enter FullName")]
        [DataType(DataType.Text)]
        [Display(Name = "BusinessFullName")]
        [MaxLength(100), MinLength(1)]
        public string BusinessFullName { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Please enter Email ID")]
        [RegularExpression(@"^[0-9A-Za-z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z0-9]+[.][a-zA-Z]{2.3}([a-zA-Z]{2,3}){0,1}", ErrorMessage = "Email is not valid.")]
        public string BusinessEmail { get; set; }
        //BusinessFullName
        [Required]
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "Please enter PhoneNumber")]
        [DataType(DataType.PhoneNumber)]
        public string BusinessPhoneNumber { get; set; }
        [Required(ErrorMessage = "Please Enter Your Plan")]
        public string BusinessPlan { get; set; }
        [Required(ErrorMessage = "Please enter Intervel"), MaxLength(30)]
        public Intervel BusinessBillingIntervel { get; set; }
        [Required(ErrorMessage = "Please Enter Street address")]
        public string BusinessStreetAddress { get; set; }
        [Required(ErrorMessage = "Please Enter City")]
        public City BusinessCity { get; set; }
        [Required(ErrorMessage = "Please Enter state")]
        public State BusinessState { get; set; }
        [Required(ErrorMessage = "Please Enter PinCode")]
        public string BusinessPostalCode { get; set; }
        [Required(ErrorMessage = "Please Enter country")]
        public Country BusinessCountry { get; set; }
        [Required(ErrorMessage = "Please Enter OldPassword")]
        public string BusinessOldPassword { get; set; }
        [Required(ErrorMessage = "Please Ente NewPAssword")]
        public string BusinessNewPassword { get; set; }

    }
}
