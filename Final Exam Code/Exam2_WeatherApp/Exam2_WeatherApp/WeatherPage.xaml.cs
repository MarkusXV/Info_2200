using Exam2_WeatherApp;

namespace Exam2_WeatherApp;

public partial class WeatherPage : ContentPage
{
  public WeatherPage()
  {
    InitializeComponent();


    LblCity.Text = WeatherGV.City;
    LblCurTemp.Text = $"Current Temp: {WeatherGV.CurTemp}°F";
    LblHighTemp.Text = $"High Temp: {WeatherGV.High}°F";
    LblLowTemp.Text = $"Low Temp: {WeatherGV.Low}°F";
    LblPressure.Text = $"Pressure: {WeatherGV.Pressure}";
    LblHumidity.Text = $"Humidity: {WeatherGV.Humidity}";
    LblWindSpeed.Text = $"Wind Speed: {WeatherGV.WindSpeed}";
    LblWindDegrees.Text = $"Wind Degrees: {WeatherGV.WindDegrees}";
    LblSunrise.Text = $"Sunrise: {WeatherGV.Sunrise}";
    LblSunset.Text = $"Sunset: {WeatherGV.Sunset}";

    if (WeatherGV.CurTemp < 32)
    {
      this.Background = Colors.Blue;
    }
    else
    {
      this.Background = Colors.Salmon;
    }

  }
}