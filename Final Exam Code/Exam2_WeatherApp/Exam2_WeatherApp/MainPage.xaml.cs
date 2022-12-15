using Newtonsoft.Json.Linq;
using System.Net;

namespace Exam2_WeatherApp;

public partial class MainPage : ContentPage
{
  const string WEATHERAPI = "4d86c9d83a242bd26bfe383353e67235";
  public MainPage()
  {
    InitializeComponent();
  }

  public static DateTime UnixTimetoCurrentTime(double unixTimeStamp)
  {
    DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
    dateTime = dateTime.AddSeconds(unixTimeStamp).ToLocalTime();
    return dateTime;
  }

  private void BtnShowTemp_Clicked(object sender, EventArgs e)
  {
    if (EntryZipCode.Text == null)
    {
      DisplayAlert("Invalid Input", "Please enter a zip code", "Close");
    }

    using (WebClient wc = new WebClient())
    {
      try
      {
        wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
        string jsontext = wc.DownloadString($"http://api.openweathermap.org/data/2.5/weather?zip={EntryZipCode.Text}&appid={WEATHERAPI}&units=imperial");


        JObject jo = JObject.Parse(jsontext);
        JObject main = JObject.Parse(jo["main"].ToString());
        JObject wind = JObject.Parse(jo["wind"].ToString());
        JObject sys = JObject.Parse(jo["sys"].ToString());


        WeatherGV.City = jo["name"].ToString();
        WeatherGV.CurTemp = double.Parse(main["temp"].ToString());
        WeatherGV.High = double.Parse(main["temp_max"].ToString());
        WeatherGV.Low = double.Parse(main["temp_min"].ToString());
        WeatherGV.Pressure = int.Parse(main["pressure"].ToString());
        WeatherGV.Humidity = int.Parse(main["humidity"].ToString());
        WeatherGV.WindSpeed = double.Parse(wind["speed"].ToString());
        WeatherGV.WindDegrees = double.Parse(wind["deg"].ToString());

        DateTime sunrise = UnixTimetoCurrentTime(double.Parse((sys["sunrise"]).ToString()));
        DateTime sunset = UnixTimetoCurrentTime(double.Parse((sys["sunset"]).ToString()));

        WeatherGV.Sunrise = sunrise;
        WeatherGV.Sunset = sunset;

        Navigation.PushAsync(new WeatherPage());

      }
      catch (Exception ex)
      {
        DisplayAlert("Error", ex.Message, "Close");
      }
    }
  }
}

