using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7_EarthquakeAPI
{
  internal class EarthquakeGV
  {
    /// <summary>
    /// Creates the variables so we can set them and read them
    /// </summary>
    public string Place { get; internal set; }
    public double Magnitude { get; internal set; }
    public int EarthquakeId { get; internal set; }
  }
}
