using System.Text.Json.Serialization;

namespace WeatherForecast
{
    public record WeatherForecast
    {
        [JsonPropertyName("condition")]
        public string? Condition { get; init; }
    }
}