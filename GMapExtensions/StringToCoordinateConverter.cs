using GMap.NET;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FYP_Project.GMapExtensions
{

    /*
     * S 1124.956 E 03400.643
     
     * 11°23'30.6"S 33°58'10.6"E
    
     * -11.391843, 33.969602
     */
    class StringToCoordinateConverter
    {
        private static string[] stringsToReplace = new[] { " ", ":", ";", "*" };

        /// <summary>
        /// Converts string Longitude and Latitude to a Coordinate that can be used on a GeoAPI map 
        /// </summary>
        /// <param name="longitude">E 33°58'10.6</param>
        /// <param name="latitude">W 087° 38.185</param>
        /// <returns></returns>
        public static PointLatLng ConvertToCoordinate(string longitude, string latitude)
        {
            //PointLatLng uses Lat Lng order instead of standard Lng Lat for parameters
            return new PointLatLng(CoordToDD(latitude), CoordToDD(longitude));
        }

        public static string ConvertBackFromLongitude(double longitude)
        {
            return DDToCoord(longitude, "lng");
        }
        public static string ConvertBackFromLatitude(double latitude)
        {
            return DDToCoord(latitude, "lat");
        }
        /// <summary>
        /// Example: 
        /// W 087° 38.185 to -87.636417°
        /// </summary>
        /// <param name="coord"></param>
        /// <returns></returns>
        private static double CoordToDD(string coord)
        {
            if (coord.Length < 2) throw new ArgumentException("The coordinate must be in format equivalent to L DD MM.MMM", coord);
            foreach(var badString in stringsToReplace)
                 coord = coord.Replace(badString, string.Empty);

            float polarity;
            switch (coord[0])
            {
                case 'N':
                case 'E':
                    polarity = 1;
                    break;
                case 'S':
                case 'W':
                    polarity = -1;
                    break;
                default:
                    throw new ArgumentException("The coordinate string must start with N,E,S or W", coord);
            }

            var dotIndex = coord.IndexOf('.');

            //if no minutes make it work on degrees
            if (dotIndex == -1) dotIndex = coord.Length + 2; 
            
            var minuteLength = coord.Length - dotIndex + 2;//6
            var minStr = coord.Substring(dotIndex - 2, minuteLength);//59.138
            var degStr = coord.Substring(1, coord.Length - minuteLength - 1);//033
            if (string.IsNullOrWhiteSpace(minStr)) minStr = "0";
            if (string.IsNullOrWhiteSpace(degStr)) degStr = "0";
            var minutes = Convert.ToDouble(minStr);
            var degrees = Convert.ToDouble(degStr);

            return polarity * (degrees + (minutes / 60.0));
        }

        private static string DDToCoord(double dd, string type)
        {
            bool isPositive = dd > 0;
            string polarity;
            if(type == "lat")
            {
                polarity = isPositive ? "N" : "S";
            }
            else if (type == "lng")
            {
                polarity = isPositive ? "E" : "W";
            }
            else
            {
                throw new ArgumentException("Needs 'lat' or 'lng' for parameter", "type");
            }
            dd = Math.Abs(dd);
            var wholenumber = Math.Floor(dd);
            var remainder = (dd - wholenumber) * 60;
            var remainderStr = remainder.ToString();

            //to follow our conversion requirement for minutes to be 2 digits before decimal
            if (remainder < 10)
            {
                remainderStr = "0" + remainderStr;
            }

            return string.Concat(polarity, wholenumber, remainderStr);
        }
    }
}
