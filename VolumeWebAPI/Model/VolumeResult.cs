using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace VolumeWebAPI.Model
{
    public class VolumeResult
    {
        [Key] [JsonPropertyName("Id")] public int Id { get; set; }

        [Required, StringLength(50)]
        [JsonPropertyName("Type")]
        public string Type { get; set; }

        [JsonPropertyName("Height")] public double Height { get; set; }
        [JsonPropertyName("Radius")] public double Radius { get; set; }
        [JsonPropertyName("Volume")] public double Volume { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}