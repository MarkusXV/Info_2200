using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M02Part2
{
    public class Phone //Creates the phone class where we create the array definitions of the phone details
    {
        public Phone(string[] phone) //Method that takes the list of the phone details from the text file and splits them into the seperate details
        {
            Make = phone[0];
            Model = phone[1];
            Display = phone[2];
            Storage = phone[3];
            Price = decimal.Parse(phone[4]);
        }

        /// <summary>
        /// Lets us have different Phone Details for each phone we pass into the method and sets it to those same values
        /// </summary>
        public string Make { get; set; }
        public string Model { get; set; }
        public string Display { get; set; }
        public string Storage { get; set; }
        public decimal Price { get; set; }

    }
}
