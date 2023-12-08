using System.IO;
using System;

namespace AdressBookApp.Server.Models
{
    public class Location
    {
        public Street Street { get; set; } = null!;
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        public string Country { get; set; } = null!;
        public int Postcode { get; set; } 
        public Coordinates Coordinates { get; set; } = null!;
        public Timezone Timezone { get; set; } = null!;
    }
}
