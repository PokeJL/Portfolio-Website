using Newtonsoft.Json;

namespace Portfolio_Website.Models
{
    public class TimelineModel
    {
        [JsonProperty(nameof(Id))]
        public int Id { get; set; }

        [JsonProperty(nameof(Title))]
        public required string Title { get; set; }

        [JsonProperty(nameof(Description))]
        public required string Description { get; set; }
    }
}
