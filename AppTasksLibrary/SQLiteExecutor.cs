using System.Data.SQLite;
using AppTasksLibrary.classes;

namespace AppTasksLibrary
{
    /// <summary>
    /// Класс для работы с таблицей Executors
    /// </summary>
    public class SQLiteExecutor
    {
        private readonly string ConnectionString;

        /// <summary>
        /// Инициализирует новый экземпляр класса
        /// </summary>
        /// <param name="connectionString"></param>
        public SQLiteExecutor(string connectionString)
        {
            ConnectionString = connectionString;
        }

        /// <summary>
        /// Добавляет нового исполнителя в базу данных
        /// </summary>
        /// <param name="executor"></param>
        public void AddExecutor(Executor executor)
        {
            using var conn = new SQLiteConnection(ConnectionString);
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = @"INSERT INTO Executors (Id, Name, Gender, DateOfBirth)
                                VALUES (@Id, @Name, @Gender, @DateOfBirth)";
            cmd.Parameters.AddWithValue("@Id", executor.Id);
            cmd.Parameters.AddWithValue("@Name", executor.Name);
            cmd.Parameters.AddWithValue("@Gender", executor.Gender);
            cmd.Parameters.AddWithValue("@DateOfBirth", executor.DateOfBirth);
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Получает список всех исполнителей из базы данных
        /// </summary>
        /// <returns></returns>
        public List<Executor> GetAllExecutors()
        {
            var executors = new List<Executor>();
            using var conn = new SQLiteConnection(ConnectionString);
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Executors";

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Guid.TryParse(reader["Id"].ToString(), out Guid id);
                DateTime.TryParse(reader["DateOfBirth"].ToString(), out DateTime birthDate);

                executors.Add(new Executor
                {
                    Id = id,
                    Name = reader["Name"].ToString(),
                    Gender = reader["Gender"].ToString(),
                    DateOfBirth = birthDate
                });
            }

            return executors;
        }

        /// <summary>
        /// Обновляет информацию об исполнителе в базе данных
        /// </summary>
        /// <param name="executor"></param>
        public void UpdateExecutor(Executor executor)
        {
            using var conn = new SQLiteConnection(ConnectionString);
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = @"UPDATE Executors SET Name=@Name, Gender=@Gender, DateOfBirth=@DateOfBirth 
                                WHERE Id=@Id";
            cmd.Parameters.AddWithValue("@Id", executor.Id);
            cmd.Parameters.AddWithValue("@Name", executor.Name);
            cmd.Parameters.AddWithValue("@Gender", executor.Gender);
            cmd.Parameters.AddWithValue("@DateOfBirth", executor.DateOfBirth);
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Удаляет исполнителя по его идентификатору
        /// </summary>
        /// <param name="executorId"></param>
        public void DeleteExecutor(Guid executorId)
        {
            using var conn = new SQLiteConnection(ConnectionString);
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM Executors WHERE Id = @Id";
            cmd.Parameters.AddWithValue("@Id", executorId);
            cmd.ExecuteNonQuery();
        }
    }
}
