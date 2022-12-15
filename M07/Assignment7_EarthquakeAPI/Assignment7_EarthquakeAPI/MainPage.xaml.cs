using Newtonsoft.Json.Linq;
using System.Net;

namespace Assignment7_EarthquakeAPI;

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
  private void BtnFindEarthquake_Clicked(object sender, EventArgs e)
  {
    if (EntryStartDate.Text == null || EntryEndDate.Text == null || EntryEarthquakeSize == null) //Checks if the entries are empty
    {
      DisplayAlert("Invalid Input", "Please enter a valid date range or Earthquake Size", "Close");
    }

    using (WebClient wc = new WebClient()) //If the values aren't empty, then we'll call the API using WebClient
    {
      try //Catches any errors in the next block
      {

        wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded"; //Tells the webclient what type we're gonna give it
        string jsontext = wc.DownloadString($"https://earthquake.usgs.gov/fdsnws/event/1/query?format=geojson&starttime={EntryStartDate.Text}&endtime={EntryEndDate.Text}&minmagnitude={EntryEarthquakeSize.Text}"); //Sets the url for the API call which includes the api key and zip code

        JObject jo = JObject.Parse(jsontext); //Gets the jsontext info and puts it into the jobject jo
        JObject EQmetadata = JObject.Parse(jo["metadata"].ToString()); //Gets the main info from jo and puts it into a jobject
        JArray eQjArray = JArray.Parse(jo["features"].ToString()); //Gets the features info from jo and puts it into a jarray

        // Get the number of earthquakes
        int count = 0;
        int.TryParse(EQmetadata["count"].ToString(), out count);

        // Creates a list of earthquakes and gets values from the API
        List<EarthquakeGV> eqList = new List<EarthquakeGV>();
        int idx = 1;
        foreach (var eq in eQjArray)
        {
          JObject eqJObj = JObject.Parse(eq["properties"].ToString());
          EarthquakeGV earthquake = new EarthquakeGV
          {
            EarthquakeId = idx,
            Magnitude = double.Parse(eqJObj["mag"].ToString()),
            Place = eqJObj["place"].ToString()
          };
          eqList.Add(earthquake);
        }

        //Gets a random earthquake and displays the results
        Random random = new Random();
        int randeq = random.Next(1, eqList.Count + 1);
        EarthquakeGV displayEQ = eqList[randeq];
        LblResults.Text = $"There were {count} earthquakes during this time.\n\n" +
           $"Details of one of them:\nPlace: {displayEQ.Place}, \nMagnitude: {displayEQ.Magnitude}.";

      }
      catch (Exception ex)
      {
        DisplayAlert("Error", ex.Message, "Close"); //Displays any errors in calling the API or setting the variables
      }
    }
  }
}

