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

        [JsonProperty(nameof(Picture_Link))]
        public required string Picture_Link { get; set; }

        [JsonProperty(nameof(Logo))]
        public required string Logo { get; set; }
    }
}
