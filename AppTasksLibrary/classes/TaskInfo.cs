namespace AppTasksLibrary.classes
{
    /// <summary>
    /// Задача
    /// </summary>
    public class TaskInfo
    {
        /// <summary>
        /// Уникальный идентификатор задачи
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Название задачи
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Подробное описание задачи
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Исполнитель задачи
        /// </summary>
        public string Executor { get; set; }

        /// <summary>
        /// Дата начала выполнения задачи
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Дата завершения задачи
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Приоритет задачи
        /// </summary>
        public string Priority { get; set; }

        /// <summary>
        /// Выполнена ли задача
        /// </summary>
        public bool IsCompleted { get; set; }
    }
}
