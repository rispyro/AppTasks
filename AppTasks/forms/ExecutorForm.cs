using AppTasksLibrary;
using AppTasksLibrary.classes;

namespace AppTasks
{
    public partial class ExecutorForm : Form
    {
        private SQLiteExecutor Executor;
        public ExecutorForm(SQLiteExecutor executor)
        {
            InitializeComponent();
            Executor = executor;
        }
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
