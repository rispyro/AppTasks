namespace AppTasksLibrary.classes
{
    /// <summary>
    /// Исполнитель задачи
    /// </summary>
    public class Executor
    {
        /// <summary>
        /// Уникальный идентификатор исполнителя
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Имя исполнителя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Пол исполнителя
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// Дата рождения исполнителя
        /// </summary>
        /// 
        public DateTime DateOfBirth { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
