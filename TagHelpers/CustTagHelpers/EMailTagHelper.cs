using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TagHelpers.CustTagHelpers
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement("My-EMail")]
    public class EMailTagHelper : TagHelper
    {
        public string MailTo { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            var mailto = MailTo+"@" + "gmail.com";
            output.Attributes.SetAttribute("href",MailTo+mailto);
        }
    }
}
