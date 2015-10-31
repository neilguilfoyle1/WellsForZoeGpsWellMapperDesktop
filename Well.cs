using GMap.NET;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using FYP_Project.GMapExtensions;

namespace FYP_Project
{
    public class Well
    {
        private static Image defaultImage;

        static Well()
        {
            defaultImage = Image.FromFile("Images\\noimage.jpg");
        }

        public string WellId { get; private set; }
        public string Longitude { get; private set; }
        public string Latitude { get; private set; }
        public string Description { get; private set; }
        public string Depth { get; private set; }
        public string WaterLevel { get; private set; }
        public string Village { get; private set; }
        public string Area { get; private set; }
        public string District { get; private set; }
        public string NumberOfPeople { get; private set; }
        public string ValveReplacementDate { get; private set; }
        public string ValveReplacedBy { get; private set; }

        private PointLatLng calculatedPoint;
        public PointLatLng CalculatedPoint 
        { 
            get
            {
                if (calculatedPoint == default(PointLatLng))
                {
                    calculatedPoint = StringToCoordinateConverter.ConvertToCoordinate(Longitude, Latitude);
                }
                return calculatedPoint;
            } 
        }

        public Image WellImage { get; private set; }

        public bool HasValidImage
        {
            get
            {
                return WellImage != null && WellImage != defaultImage;
            }
        }

        public Well(string id, string longitude, string latitude, Image image)
        {
            WellId = id;
            Longitude = longitude;
            Latitude = latitude;
            WellImage = image ?? defaultImage;
        }


        public Well(string id, string longitude, string latitude, Image image, string description, string depth, string waterLevel, 
            string village, string area, string district, string numberOfPeople, string valveReplacedBy, 
            string valveReplacementDate) : this(id, longitude, latitude, image)
        {
            Description = description;
            Depth = depth;
            WaterLevel = waterLevel;
            Village = village;
            Area = area;
            District = district;
            NumberOfPeople = numberOfPeople;
            ValveReplacedBy = valveReplacedBy;
            ValveReplacementDate = valveReplacementDate;
        }

        public void UpdateCoordinates(string longitude, string latitude)
        {
            if (string.IsNullOrWhiteSpace(longitude)) throw new ArgumentException("Cannot be empty", "longitude");
            if (string.IsNullOrWhiteSpace(latitude)) throw new ArgumentException("Cannot be empty", "latitude");

            //if there is letter we need to convert to coords
            foreach(var c in longitude)
            {
                if(char.IsLetter(c))
                {
                    calculatedPoint = StringToCoordinateConverter.ConvertToCoordinate(Longitude, Latitude);
                    Longitude = longitude;
                    Latitude = latitude;
                    return;
                }
            }
            //otherwise it was passed already converted coords and just use those
            calculatedPoint = new PointLatLng(Convert.ToDouble(latitude), Convert.ToDouble(longitude));
            Longitude = StringToCoordinateConverter.ConvertBackFromLongitude(calculatedPoint.Lng);
            Latitude = StringToCoordinateConverter.ConvertBackFromLatitude(calculatedPoint.Lat);
        }

        public void UpdateImage(Image newImage)
        {
            if (newImage != null) WellImage = newImage;
        }

        public string UpdateDetail(string description, string depth, string waterLevel, 
            string village, string area, string district, string numberOfPeople, string valveReplacedBy, 
            string valveReplacementDate)
        {
            string error = IsDouble(depth);
            if (error == null)
            {
                Depth = depth;
            }
            else
            {
                return "Depth " + error;
            }
            error = IsDouble(waterLevel);
            if (error == null)
            {
                WaterLevel = waterLevel;
            }
            else
            {
                return "Water level " + error;
            }
            int converted;
            if (string.IsNullOrEmpty(numberOfPeople) || int.TryParse(numberOfPeople, out converted))
            {
                NumberOfPeople = numberOfPeople;
            }
            else
            {
                return "Number of people must be a whole number or empty";
            }

            Description = description;
            Village = village;
            Area = area;
            District = district;
            ValveReplacedBy = valveReplacedBy;
            ValveReplacementDate = valveReplacementDate;
            return null;
        }

        private string IsDouble(string valueToCheck)
        {
            double converted;
            if (!(string.IsNullOrEmpty(valueToCheck) || double.TryParse(valueToCheck, out converted)))
            {
                return "must be a number or empty";
            }
            return null;
        }
    }
}
