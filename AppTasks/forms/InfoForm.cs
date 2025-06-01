using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using AppTasksLibrary.classes;

namespace AppTasks
{
    public partial class InfoForm : Form
    {
        private TaskInfo Task;
        private readonly List<Executor> Executors;

        public InfoForm(TaskInfo task, List<Executor> executors)
        {
            InitializeComponent();
            Task = task;
            Executors = executors;

            textTitle.Text = task.Title;
            textDescription.Text = task.Description;
            dateTimeStart.Value = task.StartDate;
            dateTimeEnd.Value = task.EndDate;
            comboPriority.SelectedItem = task.Priority;
            comboExecutor.Items.AddRange(executors.Select(e => e.Name).ToArray());
            comboExecutor.SelectedItem = task.Executor;
            checkDone.Checked = task.IsCompleted;
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textTitle.Text) || comboPriority.SelectedItem == null ||comboExecutor.SelectedItem == null)
            {
                MessageBox.Show("Не все поля заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dateTimeEnd.Value.Date < dateTimeStart.Value.Date)
            {
                MessageBox.Show("Дата окончания не может быть раньше даты начала!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Task.Title = textTitle.Text;
            Task.Description = textDescription.Text;
            Task.StartDate = dateTimeStart.Value.Date;
            Task.EndDate = dateTimeEnd.Value.Date;
            Task.Priority = comboPriority.SelectedItem.ToString();
            Task.Executor = comboExecutor.SelectedItem.ToString();
            Task.IsCompleted = checkDone.Checked;

            DialogResult = DialogResult.OK;
            Close();
        }


    }
}
