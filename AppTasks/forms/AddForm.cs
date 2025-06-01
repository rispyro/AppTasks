using AppTasksLibrary.classes;
using AppTasksLibrary;

namespace AppTasks
{
    /// <summary>
    /// Форма для добавления новой задачи в систему
    /// </summary>
    public partial class AddForm : Form
    {
        /// <summary>
        /// Объект для взаимодействия с базой данных SQLite по исполнителям
        /// </summary>
        private SQLiteExecutor Executor;
        /// <summary>
        /// Объект для взаимодействия с базой данных SQLite по задачам
        /// </summary>
        private SQLiteTaskInfo Task;
        /// <summary>
        /// Конструктор формы
        /// </summary>
        /// <param name="executor"></param>
        /// <param name="task"></param>
        public AddForm(SQLiteExecutor executor, SQLiteTaskInfo task)
        {
            InitializeComponent();
            Executor = executor;
            Task = task;
            LoadExecutors();
        }
        /// <summary>
        /// Загружает список исполнителей в выпадающий список
        /// </summary>
        private void LoadExecutors()
        {
            var executors = Executor.GetAllExecutors();
            comboExecutor.DataSource = executors;
            comboExecutor.DisplayMember = "Name";
            comboExecutor.ValueMember = "Id";
        }
        /// <summary>
        /// Обработчик события кнопки добавления задачи
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddTask_Click(object sender, EventArgs e)
        {
            var existingTasks = Task.GetAllTasks();
            if (existingTasks.Any(t =>
                t.Title.Equals(textTitle.Text, StringComparison.OrdinalIgnoreCase) &&
                t.Executor.Equals(comboExecutor.Text, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Задача с таким названием и исполнителем уже существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(textTitle.Text) || comboExecutor.SelectedItem == null || comboPriority.SelectedItem == null)
            {
                MessageBox.Show("Не все поля заполнены.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dateTimeEnd.Value.Date < dateTimeStart.Value.Date)
            {
                MessageBox.Show("Дата окончания не может быть раньше даты начала.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var task = new TaskInfo
            {
                Id = Guid.NewGuid(),
                Title = textTitle.Text,
                Description = textDescription.Text,
                Executor = comboExecutor.Text,
                StartDate = dateTimeStart.Value.Date,
                EndDate = dateTimeEnd.Value.Date,
                Priority = comboPriority.SelectedItem.ToString(),
                IsCompleted = false
            };
            Task.AddTask(task);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
