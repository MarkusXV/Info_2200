using Newtonsoft.Json.Linq;
using System.Net;

namespace Participation7_WeatherAPI;

public partial class MainPage : ContentPage
{
  const string WEATHERAPI = "4d86c9d83a242bd26bfe383353e67235"; //Constant weather api key
  public MainPage()
  {
    InitializeComponent(); //Initializes the components of the page
  }

  /// <summary>
  /// When the button is clicked, it will call the API and display the results in another window
  /// </summary>
  /// <param name="sender"></param>
  /// <param name="e"></param>
  private void BtnShowTemp_Clicked(object sender, EventArgs e)
  {
    if (EntryZipCode.Text == null) //Checks if the entry is empty
    {
      DisplayAlert("Invalid Input", "Please enter a zip code", "Close");
    }

    using (WebClient wc = new WebClient()) //If the zip isn't empty, then we'll call the API using WebClient
    {
      try //Catches any errors in the next block
      {

        wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded"; //Tells the webclient what type we're gonna give it
        string jsontext = wc.DownloadString($"http://api.openweathermap.org/data/2.5/weather?zip={EntryZipCode.Text}&appid={WEATHERAPI}&units=imperial"); //Sets the url for the API call which includes the api key and zip code

        
        JObject jo = JObject.Parse(jsontext); //Gets the jsontext info and puts it into the jobject jo
        JObject main = JObject.Parse(jo["main"].ToString()); //Gets the main info from jo and puts it into a jobject

        WeatherGV.City = jo["name"].ToString(); //Gets the name from jo and sets it to the global variable city
        WeatherGV.CurTemp = double.Parse(main["temp"].ToString()); //Gets the temp from main and sets it to the global variable curtemp
        WeatherGV.High = double.Parse(main["temp_max"].ToString()); //Gets the temp_max from main and sets it to the global variable High
        WeatherGV.Low = double.Parse(main["temp_min"].ToString()); //Gets the temp from temp_min and sets it to the global variable Low

        Navigation.PushAsync(new WeatherPage()); //Displays the new page with the newly set variables

      }
      catch (Exception ex)
      {
        DisplayAlert("Error", ex.Message, "Close"); //Displays any errors in calling the API or setting the variables
      }
    }
  }
}

