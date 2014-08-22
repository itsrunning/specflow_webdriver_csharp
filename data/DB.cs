using Npgsql;

namespace SpecFlowSample.data
{
    public class Db
    {
        public static void Run(string query)
        {
            var connection =
                new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=postgres;Password=pass;Database=microblog;");
            connection.Open();
            var sql = query;
            var command = new NpgsqlCommand(sql, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}