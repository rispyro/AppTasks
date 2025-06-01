
using AppTasksLibrary;         

namespace AppTasks
{
    /// <summary>
    /// Главная форма приложения для управления задачами и исполнителями
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Объект доступа к данным задач
        /// </summary>
        private SQLiteTaskInfo Task;
        /// <summary>
        /// бъект доступа к данным исполнителей
        /// </summary>
        private SQLiteExecutor Executor;
        /// <summary>
        /// Конструктор главной формы
        /// </summary>
        /// <param name="task"></param>
        /// <param name="executor"></param>
        public MainForm(SQLiteTaskInfo task, SQLiteExecutor executor)
        {
            InitializeComponent();
            Task = task;
            Executor = executor;
            LoadTasksToGrid();
            LoadExecutors();
        }
        /// <summary>
        /// Загружает все задачи в таблицу на форме
        /// </summary>
        private void LoadTasksToGrid()
        {
            var tasks = Task.GetAllTasks();
            dataGridTasks.DataSource = tasks.Select(t => new
            {
                Id = t.Id,
                Название = t.Title,
                Дата = t.EndDate.ToShortDateString(),
                Приоритет = t.Priority,
                Выполнено = t.IsCompleted ? "Да" : "Нет"
            }).ToList();
            dataGridTasks.Columns["Id"].Visible = false;

        }
        /// <summary>
        /// Обработчик кнопки добавления новой задачи
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var executors = Executor.GetAllExecutors();
            if (executors.Count == 0)
            {
                MessageBox.Show("Исполнителей нет. Сначала добавьте, как минимум, одного исполнителя!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var addForm = new AddForm(Executor, Task);
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadTasksToGrid();
            }
        }
        /// <summary>
        /// Обработчик события загрузки формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            string conn = "Data Source=tasks.db";
            Executor = new SQLiteExecutor(conn);
            LoadExecutors();
        }
        /// <summary>
        /// Обработчик кнопки добавления нового исполнителя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNewExecutor_Click(object sender, EventArgs e)
        {
            var form = new ExecutorForm(Executor);
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadExecutors();
            }
        }
        /// <summary>
        /// Загружает всех исполнителей в список на форме
        /// </summary>
        private void LoadExecutors()
        {
            var executors = Executor.GetAllExecutors();
            listExecutors.Items.Clear();
            foreach (var ex in executors)
            {
                listExecutors.Items.Add(ex.Name);
            }
        }
        /// <summary>
        /// Обработчик кнопки удаления задачи
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridTasks.CurrentRow == null)
            {
                MessageBox.Show("Выберите задачу для удаления!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var result = MessageBox.Show("Вы уверены, что хотите удалить задачу?", "Подтверждение", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes) return;
            var idStr = dataGridTasks.CurrentRow.Cells["Id"].Value.ToString();
            if (Guid.TryParse(idStr, out Guid taskId))
            {
                Task.DeleteTask(taskId);
                LoadTasksToGrid();
            }
            else
            {
                MessageBox.Show("Ошибка при получении Id задачи!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /// <summary>
        /// Обработчик кнопки просмотра информации о задаче
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonInfo_Click(object sender, EventArgs e)
        {
            if (dataGridTasks.CurrentRow == null)
            {
                MessageBox.Show("Выберите задачу!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var idStr = dataGridTasks.CurrentRow.Cells["Id"].Value.ToString();
            if (!Guid.TryParse(idStr, out Guid taskId))
            {
                MessageBox.Show("Невозможно получить Id задачи!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var task = Task.GetTaskById(taskId);
            if (task == null)
            {
                MessageBox.Show("Задача не найдена!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var form = new InfoForm(task, Executor.GetAllExecutors());
            if (form.ShowDialog() == DialogResult.OK)
            {
                Task.UpdateTask(task);
                LoadTasksToGrid();
            }
        }

    }
}
