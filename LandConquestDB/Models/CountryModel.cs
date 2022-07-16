﻿using Dapper;
using LandConquestDB.Entities;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;

namespace LandConquestDB.Models
{
    public class CountryModel
    {
        public static Country EstablishState(Land land, Person person, System.Windows.Media.Color color, string _countryName)
        {
            Color newColor = Color.FromArgb(color.A, color.R, color.G, color.B);
            string colorHex = ColorTranslator.ToHtml(newColor);
            string coffers = "10000";
            int capitalId = land.LandId;
            string countryQuery = "INSERT INTO dbo.CountryData (country_name, country_ruler, country_player, country_color, country_coffers, capital_id) VALUES (@country_name, @country_ruler, @country_player, @country_color, @country_coffers, @capital_id)";
            var countryCommand = new SqlCommand(countryQuery, DbContext.GetSqlConnection());

            Country country = new Country();
            country.CountryId = SelectLastIdOfStates();
            country.CountryName = _countryName;
            country.CountryRuler = person.PersonId;
            country.CountryPlayer = person.PlayerId;
            country.CountryColor = colorHex;
            country.CountryCoffers = coffers;
            country.CapitalId = capitalId;
           
            countryCommand.Parameters.AddWithValue("@country_name", country.CountryName);
            countryCommand.Parameters.AddWithValue("@country_ruler", country.CountryRuler);
            countryCommand.Parameters.AddWithValue("@country_player", country.CountryPlayer);
            countryCommand.Parameters.AddWithValue("@country_color", country.CountryColor);
            countryCommand.Parameters.AddWithValue("@country_coffers", country.CountryCoffers);
            countryCommand.Parameters.AddWithValue("@capital_id", country.CapitalId);

            countryCommand.ExecuteNonQuery();
            countryCommand.Dispose();

            return country;
        }

        public static int SelectLastIdOfStates()
        {
            string stateQuery = "SELECT TOP 1 * FROM dbo.CountryData ORDER BY country_id DESC";
            var stateCommand = new SqlCommand(stateQuery, DbContext.GetSqlConnection());
            int state_max_id = 1;

            using (var reader = stateCommand.ExecuteReader())
            {
                var stateId = reader.GetOrdinal("country_id");


                while (reader.Read())
                {
                    state_max_id = reader.GetInt32(stateId);
                }
                reader.Close();
            }
            stateCommand.Dispose();
            return state_max_id;
        }

        public static List<Country> GetCountriesInfo()
        {
            return DbContext.GetSqlConnection().Query<Country>("SELECT * FROM dbo.CountryData ORDER BY country_name ASC").ToList();
        }

        public static List<string> GetCountryLandsNamesNotWarInvolved(Country _country)
        {
            string query = "SELECT LandData.land_name FROM dbo.LandData INNER JOIN dbo.WarData ON WarData.land_attacker_id != LandData.land_id AND WarData.land_defender_id != LandData.land_id WHERE LandData.country_id = @country_id";
            List<string> landsLandNames = new List<string>();

            var command = new SqlCommand(query, DbContext.GetSqlConnection());
            command.Parameters.AddWithValue("@country_id", _country.CountryId);

            using (var reader = command.ExecuteReader())
            {
                var landName = reader.GetOrdinal("land_name");

                while (reader.Read())
                {
                    landsLandNames.Add(reader.GetString(landName));
                }
                reader.Close();
            }

            command.Dispose();

            return landsLandNames;
        }

        public static int GetCountryIdByLandId(int _landId)
        {
            return DbContext.GetSqlConnection().Query<int>("SELECT country_id FROM dbo.LandData WHERE land_id = @land_id", new { land_id = _landId }).FirstOrDefault();
        }

        public static string GetCountryRuler(int id)
        {
            string rulerId = "";
            string query = "SELECT country_ruler FROM dbo.CountryData WHERE country_id = @country_id ";

            var command = new SqlCommand(query, DbContext.GetSqlConnection());
            command.Parameters.AddWithValue("@country_id", id);

            using (var reader = command.ExecuteReader())
            {
                var countryRuler = reader.GetOrdinal("country_ruler");

                while (reader.Read())
                {
                    rulerId = reader.GetString(countryRuler);
                }
                reader.Close();
            }
            command.Dispose();
            return rulerId;
        }

        public static Country GetCountryById(int id)
        {
            Country country = new Country();

            string query = "SELECT * FROM dbo.CountryData WHERE country_id = @id";

            var command = new SqlCommand(query, DbContext.GetSqlConnection());
            command.Parameters.AddWithValue("@id", id);

            using (var reader = command.ExecuteReader())
            {
                var countryId = reader.GetOrdinal("country_id");
                var countryName = reader.GetOrdinal("country_name");
                var countryRuler = reader.GetOrdinal("country_ruler");
                var countryColor = reader.GetOrdinal("country_color");
                var countryCoffers = reader.GetOrdinal("country_coffers");
                var capitalId = reader.GetOrdinal("capital_id"); 

                while (reader.Read())
                {
                    country.CountryId = reader.GetInt32(countryId);
                    country.CountryName = reader.GetString(countryName);
                    country.CountryRuler = reader.GetString(countryRuler);
                    country.CountryColor = reader.GetString(countryColor);
                    country.CountryCoffers = reader.GetString(countryCoffers);
                    if (reader.IsDBNull(capitalId))
                        country.CapitalId = 0;
                    else
                        country.CapitalId = reader.GetInt32(capitalId);
                }
                reader.Close();
            }

            command.Dispose();

            return country;
        }

        public static void UpdateCountryCapital(Country country, int landCapitalId)
        {
            string countryQuery = "UPDATE dbo.CountryData SET capital_id = @capital_id WHERE country_id = @country_id ";

            var landCommand = new SqlCommand(countryQuery, DbContext.GetSqlConnection());
            landCommand.Parameters.AddWithValue("@country_id", country.CountryId);
            landCommand.Parameters.AddWithValue("@capital_id", landCapitalId);

            landCommand.ExecuteNonQuery();

            landCommand.Dispose();
        }


        public static void DisbandCountry(Country country)
        {
            string query = "DELETE FROM dbo.CountryData WHERE country_id = @id";

            var command = new SqlCommand(query, DbContext.GetSqlConnection());
            command.Parameters.AddWithValue("@id", country.CountryId);

            command.ExecuteNonQuery();

            command.Dispose();
        }
    }
}
