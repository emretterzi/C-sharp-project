using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kargoTakip
{
    class Courier
    {
        public string courierName { get; set; }
        public string password { get; set; }
        public Location loc { get; set; }


    }
    class Location
    {
        public string longitude { get; set; }
        public string latitude { get; set; }
    }
}
