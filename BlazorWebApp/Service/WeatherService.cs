using BlazorWebApp.Models;
using System.Net.Http.Json;

public class WeatherService
{
    private readonly HttpClient _httpClient;
    private readonly string _apiKey = "930c9103286e49f3be592336242111"; // Replace with your actual WeatherAPI.com key.

    public WeatherService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<WeatherForecast?> GetWeatherAsync(string cityName)
    {
        var url = $"current.json?key={_apiKey}&q={cityName}";
        return await _httpClient.GetFromJsonAsync<WeatherForecast>(url);
    }
}
