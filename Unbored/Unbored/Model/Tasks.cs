using System.Text.Json;
using System.Text.Json.Serialization;

namespace Unbored.Model
{
    public class Tasks
    {
        [JsonPropertyName("Health")]
        public Dictionary<string, string>? Health { get; set; }
        [JsonPropertyName("Chores")]
        public Dictionary<string, string>? Chores { get; set; }
        [JsonPropertyName("Essentials")]
        public Dictionary<string, string>? Essentials { get; set; }
        [JsonPropertyName("Activity")]
        public Dictionary<string, string>? Activity { get; set; }
        [JsonPropertyName("Productivity")]
        public Dictionary<string, string>? Productivity { get; set; }

    }
}
