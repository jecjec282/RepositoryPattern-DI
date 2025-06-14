namespace RepositoryPattern_DI.Services.WeatherForecastService
{
    public interface IWeatherForecastSerrvice
    {
        IEnumerable<WeatherForecast> Get();
    }
}
