using AppTasksLibrary;
using AppTasksLibrary.classes;

namespace AppTasks
{
    /// <summary>
    /// Форма для добавления нового исполнителя в базу данных.
    /// </summary>
    public partial class ExecutorForm : Form
    {
        /// <summary>
        /// Объект для взаимодействия с базой данных SQLite
        /// </summary>
        private SQLiteExecutor Executor;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="executor"></param>
        public ExecutorForm(SQLiteExecutor executor)
        {
            InitializeComponent();
            Executor = executor;
        }
        /// <summary>
        /// Обработчик события нажатия кнопки "Добавить исполнителя"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddExecutor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textName.Text) || comboGender.SelectedItem == null)
            {
                MessageBox.Show("Не все данные заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var executor = new Executor
            {
                Id = Guid.NewGuid(),
                Name = textName.Text,
                Gender = comboGender.SelectedItem.ToString(),
                DateOfBirth = dateTimeBirth.Value.Date
            };

            Executor.AddExecutor(executor);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
