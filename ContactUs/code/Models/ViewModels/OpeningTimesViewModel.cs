using Newtonsoft.Json;

namespace Feature.ContactUs.Models.ViewModels
{
    public class OpeningTimesViewModel
    {
        [JsonProperty("day")]
        public string Days { get; set; }

        [JsonProperty("time")]
        public string Times { get; set; }
    }
}