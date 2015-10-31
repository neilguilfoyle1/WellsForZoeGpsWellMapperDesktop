using Npgsql;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace FYP_Project.Database
{
    class DatabaseLoader
    {
        private static bool hasInternet = true;

        string connectionString;

        internal DatabaseLoader(string connectionString, bool hasInternet)
        {
            this.connectionString = connectionString;
            DatabaseLoader.hasInternet = hasInternet;
        }

        internal void AddLocationData(string village, string area, string district, string numofpeople)
        {
            if (!hasInternet) return;
            var insert = "INSERT INTO \"Location\"( \"Village\", \"Area\", \"District\", \"NumOfPeople\") VALUES (@village, @area, @district, @numofpeople);";

            using (var pgsqlConnection = new NpgsqlConnection(connectionString))
            {
                pgsqlConnection.Open();
                using (var command = new NpgsqlCommand(insert, pgsqlConnection))
                {
                    command.Parameters.AddWithValue("@village", village);
                    command.Parameters.AddWithValue("@area", area);
                    command.Parameters.AddWithValue("@district", district);
                    command.Parameters.AddWithValue("@numofpeople", numofpeople);
                    command.ExecuteNonQuery();
                }
            }
        }

        internal int UpdateLocationData(string village, string area, string district, string numofpeople)
        {
            if (!hasInternet) return -1;
            var update = "UPDATE \"Location\" SET \"Area\" = @area, \"District\" = @district, \"NumOfPeople\" = @numofpeople WHERE \"Village\" = @village;";

            using (var pgsqlConnection = new NpgsqlConnection(connectionString))
            {
                pgsqlConnection.Open();
                using (var command = new NpgsqlCommand(update, pgsqlConnection))
                {
                    command.Parameters.AddWithValue("@village", village.Trim());
                    command.Parameters.AddWithValue("@area", area.Trim());
                    command.Parameters.AddWithValue("@district", district.Trim());
                    command.Parameters.AddWithValue("@numofpeople", numofpeople);
                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }

        internal int InsertWellData(string wellLong, string wellLat, string village, string wellDepth = null, string waterLevel = null, string description = null, string valveReplacedBy = null, string valveReplacementDate = null, Image wellPhoto = null)
        {
            if (!hasInternet) return -1;
            var insert = "INSERT INTO \"Wells\"( \"WellLng\", \"WellLat\", \"WellImage\",\"WellDepth\", \"WaterLevel\", \"Description\","+
                "\"Village\", \"ValveReplacedBy\", \"ValveReplacementDate\") VALUES "+
                "(@wellLng, @wellLat, @wellPhoto, @welldepth, @waterlevel, @description, @village, @valveraplacedby, @valvereplacedate) RETURNING \"WellID\";";

            using (var pgsqlConnection = new NpgsqlConnection(connectionString))
            {
                pgsqlConnection.Open();
                using (var command = new NpgsqlCommand(insert, pgsqlConnection))
                {
                    command.Parameters.AddWithValue("@wellLng", wellLong);
                    command.Parameters.AddWithValue("@wellLat", wellLat);
                    command.Parameters.AddWithValue("@wellPhoto", wellPhoto == null ? null :ImageToDatabaseConverter.ImageToBase64(wellPhoto, wellPhoto.RawFormat));
                    command.Parameters.AddWithValue("@welldepth", wellDepth);
                    command.Parameters.AddWithValue("@waterlevel", waterLevel);
                    command.Parameters.AddWithValue("@description", description);
                    command.Parameters.AddWithValue("@village", village);
                    command.Parameters.AddWithValue("@valveraplacedby", valveReplacedBy);
                    command.Parameters.AddWithValue("@valvereplacedate", valveReplacementDate);
                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }

        internal List<Well> ReadWellData()
        {
            if (!hasInternet) return new List<Well>();
            var select = "SELECT * FROM \"Wells\";";
            var allLocationsSelect = "SELECT * FROM \"Location\"";
            var wells = new List<Well>();
            //Pass in Connection string
            using (var pgsqlConnection = new NpgsqlConnection(connectionString))
            {   //Open the connection(socket)
                pgsqlConnection.Open();
                //create dictionary array of strings
                Dictionary<string, Tuple<string, string, string>> locations = new Dictionary<string, Tuple<string, string, string>>();
                //pass in all location content, pass in connectionString
                using (var command = new NpgsqlCommand(allLocationsSelect, pgsqlConnection))
                {   
                    //create execute reader from library
                    NpgsqlDataReader dr = command.ExecuteReader();
                    //read through the data
                    while (dr.Read())
                    {   //add list into dictionary array that is being read
                        locations.Add(dr["Village"].ToString(),
                            new Tuple<string, string, string>(dr["Area"].ToString(), dr["District"].ToString(), dr["NumOfPeople"] == DBNull.Value ? null : dr["NumOfPeople"].ToString()));
                    }
                }
                //pass in all "wells" content, pass in connectionString
                using (var command = new NpgsqlCommand(select, pgsqlConnection))
                {   //Same as above
                    NpgsqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {   
                        var image = dr["WellImage"].ToString();
                        var village = dr["Village"].ToString();
                        var locationInfo = locations[village];
                        
                        wells.Add(
                            new Well(
                                dr["WellID"] == DBNull.Value ? null : dr["WellID"].ToString(),
                                dr["WellLng"] == DBNull.Value ? null : dr["WellLng"].ToString(),
                                dr["WellLat"] == DBNull.Value ? null : dr["WellLat"].ToString(),
                                string.IsNullOrWhiteSpace(image) ? 
                                null : 
                                ImageToDatabaseConverter.Base64ToImage(image),
                                dr["Description"] == DBNull.Value ? null : dr["Description"].ToString(),
                                dr["WellDepth"] == DBNull.Value ? null : dr["WellDepth"].ToString(),
                                dr["WaterLevel"] == DBNull.Value ? null : dr["WaterLevel"].ToString(),
                                village,
                                locationInfo.Item1,             //area
                                locationInfo.Item2,             //district 
                                locationInfo.Item3,             //number of people
                                dr["ValveReplacedBy"] == DBNull.Value ? null : dr["ValveReplacedBy"].ToString(),
                                dr["ValveReplacementDate"] == DBNull.Value ? null : dr["ValveReplacementDate"].ToString()
                                ));
                    }
                }
            }
            return wells;
        }

        internal bool TryLogin(string email, string passwordHash)
        {
            if (!hasInternet) return true;  //allow user to view map but it will be viewed in read only mode
            var passwordCheck = "SELECT \"Password\" FROM \"Users\" WHERE \"Username\" = @email";

            var databaseHash = string.Empty;
            using (var pgsqlConnection = new NpgsqlConnection(connectionString))
            {
                pgsqlConnection.Open();
                using (var command = new NpgsqlCommand(passwordCheck, pgsqlConnection))
                {
                    command.Parameters.AddWithValue("@email", email);
                    NpgsqlDataReader dr = command.ExecuteReader();
                    if (!dr.Read())
                    {
                        throw new Exception("The email is not registered");
                    }
                    else
                    {
                        databaseHash = dr["Password"].ToString();
                    }
                }
            }
            
            return passwordHash.Equals(databaseHash);
        }

        internal void UpdateWellData(Well well)
        {
            if (!hasInternet) return;
            var update = "UPDATE \"Wells\" SET \"WellLng\" = @wellLng, \"WellLat\" = @wellLat, \"WellImage\" = @wellPhoto, " +
                "\"WellDepth\" = @welldepth, \"Description\" = @description, \"WaterLevel\" = @waterlevel, " +
                "\"Village\" = @village, \"ValveReplacedBy\" = @valvereplacedby";
            if(!string.IsNullOrWhiteSpace(well.ValveReplacementDate))
            {
                update += ", \"ValveReplacementDate\" = to_date(@valvereplacedate, 'DD/MM/YYYY')";
            }
            update += " WHERE \"WellID\" = @wellId;";

            using (var pgsqlConnection = new NpgsqlConnection(connectionString))
            {
                pgsqlConnection.Open();
                using (var command = new NpgsqlCommand(update, pgsqlConnection))
                {
                    command.Parameters.AddWithValue("@wellid", well.WellId);
                    command.Parameters.AddWithValue("@wellLng", well.Longitude);
                    command.Parameters.AddWithValue("@wellLat", well.Latitude);
                    command.Parameters.AddWithValue("@wellPhoto", well.HasValidImage ? ImageToDatabaseConverter.ImageToBase64(well.WellImage, well.WellImage.RawFormat) : null);
                    command.Parameters.AddWithValue("@welldepth", well.Depth);
                    command.Parameters.AddWithValue("@waterlevel", well.WaterLevel);
                    command.Parameters.AddWithValue("@description", well.Description);
                    command.Parameters.AddWithValue("@village", well.Village);
                    command.Parameters.AddWithValue("@valvereplacedby", well.ValveReplacedBy);
                    command.Parameters.AddWithValue("@valvereplacedate", well.ValveReplacementDate); 
                    command.ExecuteNonQuery();
                }
            }
        }

        internal void DeleteWell(Well well)
        {
            if (!hasInternet) return;
            var update = "DELETE FROM \"Wells\" WHERE \"WellID\" = @wellId;";

            using (var pgsqlConnection = new NpgsqlConnection(connectionString))
            {
                pgsqlConnection.Open();
                using (var command = new NpgsqlCommand(update, pgsqlConnection))
                {
                    command.Parameters.AddWithValue("@wellId", well.WellId);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
