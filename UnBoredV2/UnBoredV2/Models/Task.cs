using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace UnBoredV2.Models
{
    public class Root
    {
        [JsonProperty("Task")]
        [JsonPropertyName("Task")]
        public List<Task>? Tasks { get; set; }
    }

    public class Task //TaskData
    {
        [JsonProperty("task_assigned")]
        [JsonPropertyName("task_assigned")]
        public string? AssignedTask { get; set; }

        [JsonProperty("task_type")]
        [JsonPropertyName("task_type")]
        public string? TaskType { get; set; }

        [JsonProperty("approximate_time")]
        [JsonPropertyName("approximate_time")]
        public string? Time { get; set; }

        [JsonProperty("difficulty")]
        [JsonPropertyName("difficulty")]
        public string? Difficulty { get; set; }

        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public int? IDNumber { get; set; }
    }
}
