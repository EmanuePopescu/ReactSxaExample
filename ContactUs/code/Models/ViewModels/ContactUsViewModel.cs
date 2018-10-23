using System.Collections.Generic;
using Newtonsoft.Json;

namespace Feature.ContactUs.Models.ViewModels
{
    public class ContactUsViewModel
    {
        [JsonProperty("verticalLayout")]
        public bool VerticalDisplay { get; set; }

        [JsonProperty("lightTheme")]
        public bool WhiteTheme { get; set; }

        [JsonProperty("timeTables")]
        public IEnumerable<ContactEnquiryViewModel> ContactEnquiries { get; set; }

        [JsonProperty("contacts")]
        public CtaSectionViewModel CTASection { get; set; }
    }
}