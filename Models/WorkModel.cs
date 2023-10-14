using Newtonsoft.Json;

namespace Portfolio_Website.Models
{
    public class WorkModel
    {
        [JsonProperty(nameof(Id))]
        public int Id { get; set; }

        [JsonProperty(nameof(Company))]
        public required string Company { get; set; }

        [JsonProperty(nameof(Role))]
        public required string Role { get; set;}

        [JsonProperty(nameof(Time_Frame))]
        public required string Time_Frame { get; set; }

        [JsonProperty(nameof(Description))]
        public required string Description { get; set; }

        [JsonProperty(nameof(Picture_Link))]
        public required string Picture_Link { get; set; }
    }
}
