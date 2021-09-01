using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWinformsMVP.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Vendor { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public string Transmission { get; set; }
        public override string ToString()
        {
            return $"{Vendor} - {Model} - {Year} - {Color} - {Transmission}";
        }
    }
}
