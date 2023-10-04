using Newtonsoft.Json;

namespace Portfolio_Website.Models
{
    public class LinkModel
    {
        [JsonProperty(nameof(Id))]
        public int Id { get; set; }

        [JsonProperty(nameof(Name))]
        public required string Name { get; set; }

        [JsonProperty(nameof(Description))]
        public required string Description { get; set; }

        [JsonProperty(nameof(Url))]
        public required string Url { get; set; }
    }
}
