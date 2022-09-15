using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M02Part2
{
    public class Phone
    {
        public Phone(string[] phone)
        {
            Make = phone[0];
            Model = phone[1];
            Display = phone[2];
            Storage = phone[3];
            Price = decimal.Parse(phone[4]);
        }

        public string Make { get; set; }
        public string Model { get; set; }
        public string Display { get; set; }
        public string Storage { get; set; }
        public decimal Price { get; set; }

    }
}
