using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace Unbored.Models /*VS Copy*/
{
    public class LTask //DictTask or ITask
    {
        [JsonPropertyName("Task")]
        public List<Task>? TaskL { get; set; }
    }
}
