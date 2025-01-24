using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArielAnchapaxiP3.Models
{
    public class AirportModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public Location location { get; set; }
        public string country { get; set; }
        public Contact_Info contact_info { get; set; }

        public class Location
        {
            public float latitude { get; set; }
            public float longitude { get; set; }
        }

        public class Contact_Info
        {
            public string phone { get; set; }
            public string email { get; set; }
            public string website { get; set; }
        }
    }
}
