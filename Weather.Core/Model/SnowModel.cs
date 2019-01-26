using Newtonsoft.Json;
namespace Weather.Core.Model
{
    public class SnowModel
    {
        [JsonProperty(PropertyName = "3h")]
        public double Snow { get; set; }
    }
}
