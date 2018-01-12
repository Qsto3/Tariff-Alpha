using System;
using System.ComponentModel.DataAnnotations;

namespace Alpha.Models
{
    public class Car
    {
        public int CarID { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Colour { get; set; }
        public string VIN { get; set; }
    }
}