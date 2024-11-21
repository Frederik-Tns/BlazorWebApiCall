using System.Text.Json.Serialization;
namespace BlazorWebApp.Models
{

    public class WeatherForecast
    {
        [JsonPropertyName("location")]
        public Location? Location { get; set; }

        [JsonPropertyName("current")]
        public CurrentWeather? Current { get; set; }
    }

    public class Location
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("region")]
        public string? Region { get; set; }

        [JsonPropertyName("country")]
        public string? Country { get; set; }
    }

    public class CurrentWeather
    {
        [JsonPropertyName("temp_c")]
        public float TemperatureCelsius { get; set; }

        [JsonPropertyName("condition")]
        public WeatherCondition? Condition { get; set; }
    }

    public class WeatherCondition
    {
        [JsonPropertyName("text")]
        public string? Text { get; set; }
    }

}
