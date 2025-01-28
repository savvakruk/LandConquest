﻿using Dapper;
using LandConquestDB.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace LandConquestDB.Models
{
    public class PlayerEntranceModel
    {
        public static DateTime GetLastEntrance(Player player)
        {
            string query = "SELECT * FROM dbo.PlayerEntranceData WHERE player_id = @player_id";

            //return DbContext.GetSqlConnection().Query<DateTime>("SELECT * FROM dbo.PlayerEntranceData WHERE player_id = @player_id", new { player_id = player.PlayerId }).FirstOrDefault();

            DateTime dateTime = new DateTime();

            var command = new SqlCommand(query, DbContext.GetSqlConnection());
            command.Parameters.AddWithValue("@player_id", player.PlayerId);

            using (var reader = command.ExecuteReader())
            {
                var playerId = reader.GetOrdinal("last_entrance");


                while (reader.Read())
                {
                    dateTime = reader.GetDateTime(playerId);
                }
                reader.Close();
            }
            command.Dispose();
            return dateTime;
        }

        public static DateTime GetFirstEntrance(Player player)
        {

            //return DbContext.GetSqlConnection().Query<DateTime>("SELECT * FROM dbo.PlayerEntranceData WHERE player_id = @player_id", new { player_id = player.PlayerId }).FirstOrDefault();

            string query = "SELECT * FROM dbo.PlayerEntranceData WHERE player_id = @player_id";
            DateTime dateTime = new DateTime();


            var command = new SqlCommand(query, DbContext.GetSqlConnection());
            command.Parameters.AddWithValue("@player_id", player.PlayerId);

            using (var reader = command.ExecuteReader())
            {
                var playerId = reader.GetOrdinal("first_entrance");


                while (reader.Read())
                {
                    dateTime = reader.GetDateTime(playerId);
                }
                reader.Close();
            }
            command.Dispose();
            return dateTime;
        }

        public static void SetFirstEntrance(Player player)
        {
            //DbContext.GetSqlConnection().Execute("INSERT INTO dbo.PlayerEntranceData (player_id, last_entrance, first_entrance) VALUES (@player_id, @last_entrance, @first_entrance)", new { player_id = player.PlayerId, last_entrance = DateTime.UtcNow, first_entrance = DateTime.UtcNow });

            string query = "INSERT INTO dbo.PlayerEntranceData (player_id, last_entrance, first_entrance) VALUES (@player_id, @last_entrance, @first_entrance)";
            var command = new SqlCommand(query, DbContext.GetSqlConnection());

            command.Parameters.AddWithValue("@player_id", player.PlayerId);
            command.Parameters.AddWithValue("@last_entrance", DateTime.UtcNow);
            command.Parameters.AddWithValue("@first_entrance", DateTime.UtcNow);

            command.ExecuteNonQuery();
            command.Dispose();
        }

        public static void UpdateLastEntrance(Player player)
        {
            //DbContext.GetSqlConnection().Execute("UPDATE dbo.PlayerEntranceData SET last_entrance = @last_entrance WHERE player_id = @player_id", new { last_entrance = DateTime.UtcNow, player_id = player.PlayerId });

            string query = "UPDATE dbo.PlayerEntranceData SET last_entrance = @last_entrance WHERE player_id = @player_id ";

            var command = new SqlCommand(query, DbContext.GetSqlConnection());
            command.Parameters.AddWithValue("@last_entrance", DateTime.UtcNow);
            command.Parameters.AddWithValue("@player_id", player.PlayerId);

            command.ExecuteNonQuery();
            command.Dispose();
        }

        public static PlayerEntrance GetFirstEntranceInfo(Player player, PlayerEntrance playerEntrance)
        {
            //  return DbContext.GetSqlConnection().Query<PlayerEntrance>("SELECT * FROM dbo.PlayerEntranceData WHERE player_id = @player_id", new { player_id = player.PlayerId, last_entrance = DateTime.UtcNow, first_entrance = DateTime.UtcNow }).FirstOrDefault();
            string query = "SELECT * FROM dbo.PlayerEntranceData WHERE player_id = @player_id"; //(army_id,army_size_current,army_type,army_archers_count,army_infantry_count,army_horseman_count,army_siegegun_count,local_land_id) VALUES (@army_id, @army_size_current, @army_type, @army_archers_count, @army_infantry_count, @army_horseman_count, @army_siegegun_count, @local_land_id)
            var command = new SqlCommand(query, DbContext.GetSqlConnection());

            command.Parameters.AddWithValue("@player_id", player.PlayerId);

            using (var reader = command.ExecuteReader())
            {
                var playerId = reader.GetOrdinal("player_id");
                var firstEntrance = reader.GetOrdinal("first_entrance");
                var lastEntrance = reader.GetOrdinal("last_entrance");


                while (reader.Read())
                {
                    playerEntrance.PlayerId = reader.GetString(playerId);
                    playerEntrance.FirstEntrance = reader.GetDateTime(firstEntrance);
                    playerEntrance.LastEntrance = reader.GetDateTime(lastEntrance);
                }
                reader.Close();
            }
            playerEntrance.PlayerId = player.PlayerId;
            command.Dispose();

            return playerEntrance;
        }

        public static List<PlayerEntrance> GetPlayerEntranceInfoList(List<PlayerEntrance> playerEntrances, User user)
        {
            string query = "SELECT TOP (1000) [dbo].[PlayerEntranceData].[player_id],[first_entrance],[last_entrance],[dbo].[PlayerData].[player_name] FROM [dbo].[PlayerEntranceData] JOIN [dbo].[PlayerData] on[dbo].[PlayerData].[player_id] = [dbo].[PlayerEntranceData].[player_id] order by[first_entrance] asc";

            var command = new SqlCommand(query, DbContext.GetSqlConnection());

            using (var reader = command.ExecuteReader())
            {

                var playerId = reader.GetOrdinal("player_id");
                var playerName = reader.GetOrdinal("player_name");
                var firstEntrance = reader.GetOrdinal("first_entrance");
                var lastEntrance = reader.GetOrdinal("last_entrance");

                while (reader.Read())
                {
                    PlayerEntrance playerEntrance = new PlayerEntrance();
                    playerEntrance.PlayerId = reader.GetString(playerId);
                    playerEntrance.PlayerNameForEntrance = reader.GetString(playerName);
                    playerEntrance.FirstEntrance = reader.GetDateTime(firstEntrance);
                    playerEntrance.LastEntrance = reader.GetDateTime(lastEntrance);
                    playerEntrances.Add(playerEntrance);

                }
                reader.Close();
            }
            command.Dispose();
            return playerEntrances;
        }
    }
}
