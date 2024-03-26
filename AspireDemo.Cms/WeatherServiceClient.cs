using AspireDemo.WeatherApi;

namespace AspireDemo.Cms
{
    public class WeatherServiceClient(HttpClient client)
    {
        public async Task<IEnumerable<WeatherForecast>> Get() => 
            await client.GetFromJsonAsync<IEnumerable<WeatherForecast>>("WeatherForecast");
    }
}