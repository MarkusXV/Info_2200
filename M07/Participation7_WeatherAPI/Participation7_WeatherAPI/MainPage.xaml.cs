using Newtonsoft.Json.Linq;
using System.Net;

namespace Participation7_WeatherAPI;

public partial class MainPage : ContentPage
{
	const string WEATHERAPI = "4d86c9d83a242bd26bfe383353e67235";
  public MainPage()
	{
		InitializeComponent();
	}


	private void BtnShowTemp_Clicked(object sender, EventArgs e)
	{
		if (EntryZipCode.Text != "")
		{
      using (WebClient wc = new WebClient())
      {
				try
				{
          wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
          string jsontext = wc.DownloadString($"http://api.openweathermap.org/data/2.5/weather?zip={EntryZipCode.Text}&appid={WEATHERAPI}&units=imperial");

					JObject jo = JObject.Parse(jsontext);
        }
				catch (Exception ex)
				{
					DisplayAlert("Error", ex.Message, "Close");
				}
      }
    }
	}
}

