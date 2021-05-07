using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetWell
{
    class LocalisationData
    {
        public static double lat = 0; 
        public static double lng = 0; 


        public static string Get()
        {
            return "latitude: " + lat + "\nlongitude: " + lng; 
        }
    }
}
