using System.Data.SQLite;

namespace AppTasksLibrary
{
    /// <summary>
    /// Отвечает за начальную инициализацию базы данных: создание таблиц при первом запуске
    /// </summary>
    public static class DatabaseInitializer
    {
        /// <summary>
        /// Создает таблицы Tasks и Executors
        /// </summary>
        /// <param name="connectionString"></param>
        public static void EnsureTablesExist(string connectionString)
        {
            using var conn = new SQLiteConnection(connectionString);
            conn.Open();

            var cmd = conn.CreateCommand();

            cmd.CommandText = @"
                CREATE TABLE IF NOT EXISTS Tasks (
                    Id TEXT PRIMARY KEY,
                    Title TEXT NOT NULL,
                    Description TEXT,
                    Executor TEXT,
                    StartDate TEXT,
                    EndDate TEXT,
                    Priority TEXT,
                    IsCompleted INTEGER DEFAULT 0
                );";
            cmd.ExecuteNonQuery();

            cmd.CommandText = @"
                CREATE TABLE IF NOT EXISTS Executors (
                    Id TEXT PRIMARY KEY,
                    Name TEXT NOT NULL,
                    Gender TEXT,
                    DateOfBirth TEXT
                );";
            cmd.ExecuteNonQuery();
        }
    }
}
