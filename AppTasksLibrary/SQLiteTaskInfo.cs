using System.Data.SQLite;
using AppTasksLibrary.classes;

namespace AppTasksLibrary
{
    /// <summary>
    /// Класс для работы с задачами
    /// </summary>
    public class SQLiteTaskInfo
    {
        private readonly string ConnectionString;

        /// <summary>
        /// Создает новый экземпляр класса
        /// </summary>
        /// <param name="connectionString"></param>
        public SQLiteTaskInfo(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        /// <summary>
        /// Добавляет новую задачу в таблицу
        /// </summary>
        /// <param name="task"></param>
        public void AddTask(TaskInfo task)
        {
            using var conn = new SQLiteConnection(ConnectionString);
            conn.Open();
            var cmd = conn.CreateCommand();
            cmd.CommandText = @"
                INSERT INTO Tasks (Id, Title, Description, Executor, StartDate, EndDate, Priority, IsCompleted)
                VALUES (@Id, @Title, @Description, @Executor, @StartDate, @EndDate, @Priority, @IsCompleted)";
            cmd.Parameters.AddWithValue("@Id", task.Id.ToString());
            cmd.Parameters.AddWithValue("@Title", task.Title);
            cmd.Parameters.AddWithValue("@Description", task.Description ?? "");
            cmd.Parameters.AddWithValue("@Executor", task.Executor ?? "");
            cmd.Parameters.AddWithValue("@StartDate", task.StartDate.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@EndDate", task.EndDate.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@Priority", task.Priority);
            cmd.Parameters.AddWithValue("@IsCompleted", task.IsCompleted ? 1 : 0);
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Возвращает список всех задач из таблицы
        /// </summary>
        /// <returns></returns>
        public List<TaskInfo> GetAllTasks()
        {
            var tasks = new List<TaskInfo>();
            using var conn = new SQLiteConnection(ConnectionString);
            conn.Open();
            var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Tasks";
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Guid.TryParse(reader["Id"].ToString(), out Guid id);
                DateTime.TryParse(reader["StartDate"].ToString(), out DateTime start);
                DateTime.TryParse(reader["EndDate"].ToString(), out DateTime end);

                tasks.Add(new TaskInfo
                {
                    Id = id,
                    Title = reader["Title"].ToString(),
                    Description = reader["Description"].ToString(),
                    Executor = reader["Executor"].ToString(),
                    StartDate = start,
                    EndDate = end,
                    Priority = reader["Priority"].ToString(),
                    IsCompleted = Convert.ToInt32(reader["IsCompleted"]) == 1
                });
            }
            return tasks;
        }

        /// <summary>
        /// Обновляет данные о задаче
        /// </summary>
        /// <param name="task"></param>
        public void UpdateTask(TaskInfo task)
        {
            using var conn = new SQLiteConnection(ConnectionString);
            conn.Open();
            var cmd = conn.CreateCommand();
            cmd.CommandText = @"
        UPDATE Tasks
        SET Title = @Title,
            Description = @Description,
            Executor = @Executor,
            StartDate = @StartDate,
            EndDate = @EndDate,
            Priority = @Priority,
            IsCompleted = @IsCompleted
        WHERE Id = @Id;";
            cmd.Parameters.AddWithValue("@Id", task.Id.ToString());
            cmd.Parameters.AddWithValue("@Title", task.Title);
            cmd.Parameters.AddWithValue("@Description", task.Description ?? "");
            cmd.Parameters.AddWithValue("@Executor", task.Executor ?? "");
            cmd.Parameters.AddWithValue("@StartDate", task.StartDate.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@EndDate", task.EndDate.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@Priority", task.Priority ?? "");
            cmd.Parameters.AddWithValue("@IsCompleted", task.IsCompleted ? 1 : 0);
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Удаляет задачу по идентификатору
        /// </summary>
        /// <param name="id"></param>
        public void DeleteTask(Guid id)
        {
            using var conn = new SQLiteConnection(ConnectionString);
            conn.Open();
            var cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM Tasks WHERE Id = @Id";
            cmd.Parameters.AddWithValue("@Id", id.ToString());
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Возвращает задачу по её идентификатору
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TaskInfo GetTaskById(Guid id)
        {
            using var conn = new SQLiteConnection(ConnectionString);
            conn.Open();
            var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Tasks WHERE Id = @Id";
            cmd.Parameters.AddWithValue("@Id", id.ToString());

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                Guid.TryParse(reader["Id"].ToString(), out Guid taskId);
                DateTime.TryParse(reader["StartDate"].ToString(), out DateTime start);
                DateTime.TryParse(reader["EndDate"].ToString(), out DateTime end);

                return new TaskInfo
                {
                    Id = taskId,
                    Title = reader["Title"].ToString(),
                    Description = reader["Description"].ToString(),
                    Executor = reader["Executor"].ToString(),
                    StartDate = start,
                    EndDate = end,
                    Priority = reader["Priority"].ToString(),
                    IsCompleted = Convert.ToInt32(reader["IsCompleted"]) == 1
                };
            }
            return null;
        }
    }
}
