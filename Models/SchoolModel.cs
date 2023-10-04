using Newtonsoft.Json;

namespace Portfolio_Website.Models
{
    public class SchoolModel
    {
        [JsonProperty(nameof(Id))]
        public int Id { get; set; }

        [JsonProperty(nameof(Degree))]
        public required string Degree { get; set; }

        [JsonProperty(nameof(School))]
        public required string School { get; set;}

        [JsonProperty(nameof(Time_Frame))]
        public required string Time_Frame { get; set; }

        [JsonProperty(nameof(Description))]
        public required string Description { get; set; }
    }
}
