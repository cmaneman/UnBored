using System.Text.Json;
using System.Text.Json.Serialization;

namespace Unbored.Model
{
    public class TaskData
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