using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace VolumeWeb.Model
{
    public class VolumeResult
    {
        [Key]  public int Id { get; set; }

        [Required, StringLength(50)]
        
        public string Type { get; set; }

        public double Height { get; set; }
        public double Radius { get; set; }
        public double Volume { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}