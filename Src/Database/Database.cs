using Npgsql;

namespace Database
{
    public static class DatabaseConnectione
    {
        private static readonly string HOST = Environment.GetEnvironmentVariable("HOST") ?? "";
        private static readonly string USER = Environment.GetEnvironmentVariable("USER") ?? "";
        private static readonly string PASSWD = Environment.GetEnvironmentVariable("PASSWD") ?? "";
        private static readonly int PORT = int.Parse(Environment.GetEnvironmentVariable("PORT") ?? "5432");
        private static readonly string DBNAME = Environment.GetEnvironmentVariable("DB_NAME") ?? "";

        private static readonly NpgsqlConnection connection = new(
            $"Host={HOST};Username={USER};Password={PASSWD};Database={DBNAME};Port={PORT}"
        );

        private static NpgsqlConnection GetConnection()
        {
            return connection;
        }

        public static void OpenConnection()
        {
            GetConnection().Open();
        }

        public static void CloseConnection()
        {
            GetConnection().Close();
        }

        public static NpgsqlCommand Command(string query)
        {
            return new NpgsqlCommand(query, GetConnection());
        }
    }
}