namespace Participation7_WeatherAPI;

public partial class WeatherPage : ContentPage
{
	public WeatherPage()
	{
		InitializeComponent(); //Initializes the components of the page

		LblCity.Text = WeatherGV.City; //Sets the label text to the city
		LblCurTemp.Text = $"Current Temp: {WeatherGV.CurTemp}°F"; //Sets the label text to the current temperature
    LblHighTemp.Text = $"High Temp: {WeatherGV.High}°F"; //Sets the label text to the high temp for the day
    LblLowTemp.Text = $"Low Temp: {WeatherGV.Low}°F"; //Sets the label text to the low temp for the day

  }
}