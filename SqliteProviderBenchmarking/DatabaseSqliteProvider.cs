using System.Data.SQLite;
using Microsoft.Data.Sqlite;

namespace SqliteProviderBenchmarking
{
    public sealed class DatabaseSqliteProvider
    {
        private readonly string _query;

        public DatabaseSqliteProvider()
        {
            _query = File.ReadAllText("CreateDb.sql");
        }

        public void InitWithSqlite()
        {
            var sqliteConnection = new SQLiteConnection($"Data Source=:memory:");
            sqliteConnection.Open();

            using var createCommand = new SQLiteCommand(_query, sqliteConnection);
            createCommand.ExecuteNonQuery();
        }

        public void InitWithMsSqlite()
        {
            var sqliteConnection = new SqliteConnection($"Data Source=:memory:");
            sqliteConnection.Open();

            using var createCommand = new SqliteCommand(_query, sqliteConnection);
            createCommand.ExecuteNonQuery();
        }
    }
}