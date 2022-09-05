using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSkocko_872019
{
    public class DatabaseUtil
    {
        private SqlConnection connection;

        public DatabaseUtil()
        {
            this.connection = DatabaseConnection.Instance.Connection;
        }

        public void SavePlayerScore(PlayerScore playerScore)
        {
            connection.Open();

            string queryStatement = @"INSERT INTO dbo.Scores (player_name, game_duration, number_of_guesses, has_guessed_solution)
                                      VALUES (@pname, @duration, @nguesses, @has_guessed)";

            using (SqlCommand cmd = new SqlCommand(queryStatement, connection))
            {
                cmd.Parameters.Add("@pname", SqlDbType.NVarChar, 20).Value = playerScore.PlayerName;
                cmd.Parameters.Add("@duration", SqlDbType.Int).Value = playerScore.GameDuration;
                cmd.Parameters.Add("@nguesses", SqlDbType.SmallInt).Value = playerScore.NumberOfGuesses;
                cmd.Parameters.Add("@has_guessed", SqlDbType.Bit).Value = playerScore.HasGuessedSolution;
                cmd.Prepare();

                cmd.ExecuteNonQuery();
            }

            connection.Close();
        }

        public List<PlayerScore> GetTopTenScores()
        {
            List<PlayerScore> scores = null;
            connection.Open();

            string queryStatement = @"SELECT TOP 10 
                                        player_name, game_duration, number_of_guesses, has_guessed_solution, 
                                        has_guessed_solution * (100 - (number_of_guesses*10 + game_duration/12)) as score 
                                      FROM dbo.Scores 
                                      ORDER BY score DESC";

            using (SqlCommand cmd = new SqlCommand(queryStatement, connection))
            {
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    if (rdr.HasRows)
                    {
                        scores = new List<PlayerScore>();

                        PlayerScore playerScore;
                        while (rdr.Read())
                        {
                            playerScore = new PlayerScore();
                            playerScore.PlayerName = rdr.GetString(0);
                            playerScore.GameDuration = rdr.GetInt32(1);
                            playerScore.NumberOfGuesses = rdr.GetInt16(2);
                            playerScore.HasGuessedSolution = rdr.GetBoolean(3);
                            playerScore.Score = rdr.GetInt32(4);

                            scores.Add(playerScore);
                        }
                    }
                }
            }

            connection.Close();

            return scores;
        }
    }
}
