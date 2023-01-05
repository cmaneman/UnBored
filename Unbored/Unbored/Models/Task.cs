using System.Text.Json; /*VS copy*/
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;


namespace Unbored.Models
{
    public class Task //TaskData
    {

        [JsonPropertyName("task_assigned")]
        public string? AssignedTask { get; set; }

        [JsonPropertyName("task_type")]
        public string? TaskType { get; set; }

        [JsonPropertyName("approximate_time")]
        public string? Time { get; set; }

        [JsonPropertyName("difficulty")]
        public string? Difficulty { get; set; }

        [JsonPropertyName("id")]
        public int? IDNumber { get; set; }
    }
}
