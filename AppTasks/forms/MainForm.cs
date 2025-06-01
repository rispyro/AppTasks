
using AppTasksLibrary;         

namespace AppTasks
{
    public partial class MainForm : Form
    {
        private SQLiteTaskInfo Task;
        private SQLiteExecutor Executor;
        public MainForm(SQLiteTaskInfo task, SQLiteExecutor executor)
        {
            InitializeComponent();
            Task = task;
            Executor = executor;
            LoadTasksToGrid();
            LoadExecutors();
        }
        private void LoadTasksToGrid()
        {
            var tasks = Task.GetAllTasks();
            dataGridTasks.DataSource = tasks.Select(t => new
            {
                Id = t.Id,
                �������� = t.Title,
                ���� = t.EndDate.ToShortDateString(),
                ��������� = t.Priority,
                ��������� = t.IsCompleted ? "��" : "���"
            }).ToList();
            dataGridTasks.Columns["Id"].Visible = false;

        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var executors = Executor.GetAllExecutors();
            if (executors.Count == 0)
            {
                MessageBox.Show("������������ ���. ������� ��������, ��� �������, ������ �����������!", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var addForm = new AddForm(Executor, Task);
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadTasksToGrid();
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            string conn = "Data Source=tasks.db";
            Executor = new SQLiteExecutor(conn);
            LoadExecutors();
        }
        private void buttonNewExecutor_Click(object sender, EventArgs e)
        {
            var form = new ExecutorForm(Executor);
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadExecutors();
            }
        }
        private void LoadExecutors()
        {
            var executors = Executor.GetAllExecutors();
            listExecutors.Items.Clear();
            foreach (var ex in executors)
            {
                listExecutors.Items.Add(ex.Name);
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridTasks.CurrentRow == null)
            {
                MessageBox.Show("�������� ������ ��� ��������!", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var result = MessageBox.Show("�� �������, ��� ������ ������� ������?", "�������������", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes) return;
            var idStr = dataGridTasks.CurrentRow.Cells["Id"].Value.ToString();
            if (Guid.TryParse(idStr, out Guid taskId))
            {
                Task.DeleteTask(taskId);
                LoadTasksToGrid();
            }
            else
            {
                MessageBox.Show("������ ��� ��������� Id ������!", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            if (dataGridTasks.CurrentRow == null)
            {
                MessageBox.Show("�������� ������!", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var idStr = dataGridTasks.CurrentRow.Cells["Id"].Value.ToString();
            if (!Guid.TryParse(idStr, out Guid taskId))
            {
                MessageBox.Show("���������� �������� Id ������!", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var task = Task.GetTaskById(taskId);
            if (task == null)
            {
                MessageBox.Show("������ �� �������!", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
