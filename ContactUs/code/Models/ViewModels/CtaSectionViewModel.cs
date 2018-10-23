using Newtonsoft.Json;

namespace Feature.ContactUs.Models.ViewModels
{
    public class CtaSectionViewModel
    {
        [JsonProperty("icon")]
        public string IconClass { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("ctaText")]
        public string CTAText { get; set; }

        [JsonProperty("ctaURL")]
        public string CTALink { get; set; }
    }
}