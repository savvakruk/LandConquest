﻿using Dapper;
using LandConquestDB.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;

namespace LandConquestDB.Models
{
    public class LandModel
    {
        public static List<Land> GetLandsInfo(List<Land> lands)
        {
            string query = "SELECT * FROM dbo.LandData";
            List<int> landsLandId = new List<int>();
            List<string> landsLandName = new List<string>();
            List<string> landsLandColor = new List<string>();
            List<int> landsCountryId = new List<int>();
            List<int> landsResourceType1 = new List<int>();
            List<int> landsResourceType2 = new List<int>();

            var command = new SqlCommand(query, DbContext.GetSqlConnection());

            using (var reader = command.ExecuteReader())
            {
                var landId = reader.GetOrdinal("land_id");
                var landName = reader.GetOrdinal("land_name");
                var landColor = reader.GetOrdinal("land_color");
                var landCountryId = reader.GetOrdinal("country_id");
                var landResourceType1 = reader.GetOrdinal("resource_type_1");
                var landResourceType2 = reader.GetOrdinal("resource_type_2");

                while (reader.Read())
                {
                    landsLandId.Add(reader.GetInt32(landId));
                    landsLandName.Add(reader.GetString(landName));
                    landsLandColor.Add(reader.GetString(landColor));
                    landsCountryId.Add(reader.GetInt32(landCountryId));
                    landsResourceType1.Add(reader.GetInt32(landResourceType1));
                    landsResourceType2.Add(reader.GetInt32(landResourceType2));
                }
                reader.Close();
            }

            command.Dispose();

            for (int i = 0; i < landsLandId.Count; i++)
            {
                lands[i].LandId = landsLandId[i];
                lands[i].LandName = landsLandName[i];
                lands[i].LandColor = landsLandColor[i];
                lands[i].CountryId = landsCountryId[i];
                lands[i].ResourceType1 = landsResourceType1[i];
                lands[i].ResourceType2 = landsResourceType2[i];
            }

            landsLandId = null;
            landsLandName = null;
            landsLandColor = null;
            landsCountryId = null;
            landsResourceType1 = null;
            landsResourceType2 = null;

            return lands;
        }

        public static List<Land> GetLandsInfo(List<Land> lands, SqlConnection connection)
        {
            string query = "SELECT * FROM dbo.LandData";
            List<int> landsLandId = new List<int>();
            List<string> landsLandName = new List<string>();
            List<string> landsLandColor = new List<string>();
            List<int> landsCountryId = new List<int>();
            List<int> landsResourceType1 = new List<int>();
            List<int> landsResourceType2 = new List<int>();

            var command = new SqlCommand(query, connection);

            using (var reader = command.ExecuteReader())
            {
                var landId = reader.GetOrdinal("land_id");
                var landName = reader.GetOrdinal("land_name");
                var landColor = reader.GetOrdinal("land_color");
                var landCountryId = reader.GetOrdinal("country_id");
                var landResourceType1 = reader.GetOrdinal("resource_type_1");
                var landResourceType2 = reader.GetOrdinal("resource_type_2");

                while (reader.Read())
                {
                    landsLandId.Add(reader.GetInt32(landId));
                    landsLandName.Add(reader.GetString(landName));
                    landsLandColor.Add(reader.GetString(landColor));
                    landsCountryId.Add(reader.GetInt32(landCountryId));
                    landsResourceType1.Add(reader.GetInt32(landResourceType1));
                    landsResourceType2.Add(reader.GetInt32(landResourceType2));
                }
                reader.Close();
            }

            command.Dispose();

            for (int i = 0; i < landsLandId.Count; i++)
            {
                lands[i].LandId = landsLandId[i];
                lands[i].LandName = landsLandName[i];
                lands[i].LandColor = landsLandColor[i];
                lands[i].CountryId = landsCountryId[i];
                lands[i].ResourceType1 = landsResourceType1[i];
                lands[i].ResourceType2 = landsResourceType2[i];
            }

            landsLandId = null;
            landsLandName = null;
            landsLandColor = null;
            landsCountryId = null;
            landsResourceType1 = null;
            landsResourceType2 = null;

            return lands;
        }

        public static Land GetLandInfo(int _landId)
        {
            //Land land = new Land();
            //string query = "SELECT * FROM dbo.LandData where land_id = @land_id";

            //var command = new SqlCommand(query, DbContext.GetSqlConnection());
            //command.Parameters.AddWithValue("@land_id", landId);

            //using (var reader = command.ExecuteReader())
            //{
            //    var landLandId = reader.GetOrdinal("land_id");
            //    var landName = reader.GetOrdinal("land_name");
            //    var landColor = reader.GetOrdinal("land_color");
            //    var landCountryId = reader.GetOrdinal("country_id");
            //    var landResourceType1 = reader.GetOrdinal("resource_type_1");
            //    var landResourceType2 = reader.GetOrdinal("resource_type_2");

            //    while (reader.Read())
            //    {
            //        land.LandId = reader.GetInt32(landLandId);
            //        land.LandName = reader.GetString(landName);
            //        land.LandColor = reader.GetString(landColor);
            //        land.CountryId = reader.GetInt32(landCountryId);
            //        land.ResourceType1 = reader.GetInt32(landResourceType1);
            //        land.ResourceType2 = reader.GetInt32(landResourceType2);
            //    }
            //    reader.Close();
            //}

            //command.Dispose();

            //return land;
            return DbContext.GetSqlConnection().Query<Land>("SELECT * FROM dbo.LandData WHERE land_id = @land_id", new { land_id = _landId }).ToList().FirstOrDefault();
        }

        public static Land GetLandInfoByName(string _landName)
        {
            Land land = new Land();
            string query = "SELECT * FROM dbo.LandData where land_name = @land_name";

            var command = new SqlCommand(query, DbContext.GetSqlConnection());
            command.Parameters.AddWithValue("@land_name", _landName);

            using (var reader = command.ExecuteReader())
            {
                var landLandId = reader.GetOrdinal("land_id");
                var landName = reader.GetOrdinal("land_name");
                var landColor = reader.GetOrdinal("land_color");
                var landCountryId = reader.GetOrdinal("country_id");
                var landResourceType1 = reader.GetOrdinal("resource_type_1");
                var landResourceType2 = reader.GetOrdinal("resource_type_2");

                while (reader.Read())
                {
                    land.LandId = reader.GetInt32(landLandId);
                    land.LandName = reader.GetString(landName);
                    land.LandColor = reader.GetString(landColor);
                    land.CountryId = reader.GetInt32(landCountryId);
                    land.ResourceType1 = reader.GetInt32(landResourceType1);
                    land.ResourceType2 = reader.GetInt32(landResourceType2);
                }
                reader.Close();
            }

            command.Dispose();

            return land;
        }

        public static void UpdateLandInfo(Land land, Country country)
        {
            string landQuery = "UPDATE dbo.LandData SET land_color = @country_color, country_id = @country_id WHERE land_id = @land_id";

            var landCommand = new SqlCommand(landQuery, DbContext.GetSqlConnection());
            landCommand.Parameters.AddWithValue("@country_id", country.CountryId);
            landCommand.Parameters.AddWithValue("@land_id", land.LandId);
            landCommand.Parameters.AddWithValue("@country_color", country.CountryColor);

            landCommand.ExecuteNonQuery();

            landCommand.Dispose();

        }

        public static void AddLandManufactures(Land land)
        {
            string manufactureQuery = "INSERT INTO dbo.LandManufactureData (land_id,manufacture_id,manufacture_name,manufacture_type) VALUES (@player_id, @manufacture_id, @manufacture_name, @manufacture_type)";

            //wood
            var woodCommand = new SqlCommand(manufactureQuery, DbContext.GetSqlConnection());
            string name = "";
            switch (land.ResourceType1)
            {
                case 4:
                    {
                        name = "Iron factory";
                        break;
                    }
                case 5:
                    {
                        name = "Gold mine";
                        break;
                    }
                case 6:
                    {
                        name = "Copper factory";
                        break;
                    }
                case 7:
                    {
                        name = "Gems industry";
                        break;
                    }
                case 8:
                    {
                        name = "Leather farm";
                        break;
                    }
            }


            woodCommand.Parameters.AddWithValue("@player_id", land.LandId);
            woodCommand.Parameters.AddWithValue("@manufacture_id", GenerateUserId());
            woodCommand.Parameters.AddWithValue("@manufacture_name", name);
            woodCommand.Parameters.AddWithValue("@manufacture_type", land.ResourceType1);

            woodCommand.ExecuteNonQuery();
            woodCommand.Dispose();

            var stoneCommand = new SqlCommand(manufactureQuery, DbContext.GetSqlConnection());

            switch (land.ResourceType2)
            {
                case 4:
                    {
                        name = "Iron factory";
                        break;
                    }
                case 5:
                    {
                        name = "Gold mine";
                        break;
                    }
                case 6:
                    {
                        name = "Copper factory";
                        break;
                    }
                case 7:
                    {
                        name = "Gems industry";
                        break;
                    }
                case 8:
                    {
                        name = "Leather farm";
                        break;
                    }
            }


            stoneCommand.Parameters.AddWithValue("@player_id", land.LandId);
            stoneCommand.Parameters.AddWithValue("@manufacture_id", GenerateUserId());
            stoneCommand.Parameters.AddWithValue("@manufacture_name", name);
            stoneCommand.Parameters.AddWithValue("@manufacture_type", land.ResourceType2);

            stoneCommand.ExecuteNonQuery();
            stoneCommand.Dispose();
        }

        public static List<Land> GetCountryLands(int _countryid)
        {
            return DbContext.GetSqlConnection().Query<Land>("SELECT * FROM dbo.LandData WHERE country_id = @country_id ORDER BY land_name ASC", new { country_id = _countryid }).ToList();
        }




        private static Random random;
        private static string GenerateUserId()
        {
            Thread.Sleep(15);
            random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvmxyz0123456789";
            return new string(Enumerable.Repeat(chars, 16)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
