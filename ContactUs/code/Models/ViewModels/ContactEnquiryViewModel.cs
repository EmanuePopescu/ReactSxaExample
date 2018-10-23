using System.Collections.Generic;
using Newtonsoft.Json;
using Feature.ContactUs.Models.ContentTypes;

namespace Feature.ContactUs.Models.ViewModels
{
    public class ContactEnquiryViewModel
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("openings")]
        public IEnumerable<OpeningTimesViewModel> OpeningTimes { get; set; } = new List<OpeningTimesViewModel>();
    }
}