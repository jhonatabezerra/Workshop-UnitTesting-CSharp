namespace ProjectTester_Services
{
    public class WeatherForecastProvider
    {
        public string[] Summaries { get; set; } = new[] { "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching" };

        public string[] GetWeatherForecast() => Summaries;
    }
}