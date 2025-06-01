namespace AppTasks
{
    partial class AddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            textTitle = new TextBox();
            textDescription = new TextBox();
            comboExecutor = new ComboBox();
            comboPriority = new ComboBox();
            dateTimeStart = new DateTimePicker();
            dateTimeEnd = new DateTimePicker();
            labelTitle = new Label();
            labelDescription = new Label();
            labelStartDate = new Label();
            labelEndDate = new Label();
            labelExecutor = new Label();
            labelPriority = new Label();
            buttonAddTask = new Button();
            SuspendLayout();
            // 
            // textTitle
            // 
            textTitle.BackColor = Color.FromArgb(251, 222, 156);
            textTitle.Font = new Font("Segoe UI", 11F);
            textTitle.ForeColor = Color.FromArgb(69, 21, 27);
            textTitle.Location = new Point(158, 34);
            textTitle.Multiline = true;
            textTitle.Name = "textTitle";
            textTitle.Size = new Size(312, 67);
            textTitle.TabIndex = 0;
            // 
            // textDescription
            // 
            textDescription.BackColor = Color.FromArgb(251, 222, 156);
            textDescription.Font = new Font("Segoe UI", 11F);
            textDescription.ForeColor = Color.FromArgb(69, 21, 27);
            textDescription.Location = new Point(159, 107);
            textDescription.Multiline = true;
            textDescription.Name = "textDescription";
            textDescription.Size = new Size(312, 218);
            textDescription.TabIndex = 1;
            // 
            // comboExecutor
            // 
            comboExecutor.BackColor = Color.FromArgb(251, 222, 156);
            comboExecutor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboExecutor.Font = new Font("Segoe UI", 11F);
            comboExecutor.ForeColor = Color.FromArgb(69, 21, 27);
            comboExecutor.FormattingEnabled = true;
            comboExecutor.Location = new Point(158, 331);
            comboExecutor.Name = "comboExecutor";
            comboExecutor.Size = new Size(313, 33);
            comboExecutor.TabIndex = 2;
            // 
            // comboPriority
            // 
            comboPriority.BackColor = Color.FromArgb(251, 222, 156);
            comboPriority.DropDownStyle = ComboBoxStyle.DropDownList;
            comboPriority.Font = new Font("Segoe UI", 11F);
            comboPriority.ForeColor = Color.FromArgb(69, 21, 27);
            comboPriority.FormattingEnabled = true;
            comboPriority.Items.AddRange(new object[] { "Низкий", "Средний", "Высокий" });
            comboPriority.Location = new Point(158, 448);
            comboPriority.Name = "comboPriority";
            comboPriority.Size = new Size(311, 33);
            comboPriority.TabIndex = 3;
            // 
            // dateTimeStart
            // 
            dateTimeStart.Font = new Font("Segoe UI", 11F);
            dateTimeStart.Location = new Point(158, 370);
            dateTimeStart.Name = "dateTimeStart";
            dateTimeStart.Size = new Size(312, 32);
            dateTimeStart.TabIndex = 4;
            // 
            // dateTimeEnd
            // 
            dateTimeEnd.Font = new Font("Segoe UI", 11F);
            dateTimeEnd.Location = new Point(158, 408);
            dateTimeEnd.Name = "dateTimeEnd";
            dateTimeEnd.Size = new Size(312, 32);
            dateTimeEnd.TabIndex = 5;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            labelTitle.ForeColor = Color.FromArgb(69, 21, 27);
            labelTitle.Location = new Point(15, 34);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(87, 23);
            labelTitle.TabIndex = 6;
            labelTitle.Text = "Название";
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            labelDescription.ForeColor = Color.FromArgb(69, 21, 27);
            labelDescription.Location = new Point(12, 107);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(89, 23);
            labelDescription.TabIndex = 7;
            labelDescription.Text = "Описание";
            // 
            // labelStartDate
            // 
            labelStartDate.AutoSize = true;
            labelStartDate.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            labelStartDate.ForeColor = Color.FromArgb(69, 21, 27);
            labelStartDate.Location = new Point(15, 370);
            labelStartDate.Name = "labelStartDate";
            labelStartDate.Size = new Size(109, 23);
            labelStartDate.TabIndex = 8;
            labelStartDate.Text = "Дата начала";
            // 
            // labelEndDate
            // 
            labelEndDate.AutoSize = true;
            labelEndDate.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            labelEndDate.ForeColor = Color.FromArgb(69, 21, 27);
            labelEndDate.Location = new Point(12, 408);
            labelEndDate.Name = "labelEndDate";
            labelEndDate.Size = new Size(139, 23);
            labelEndDate.TabIndex = 9;
            labelEndDate.Text = "Дата окончания";
            // 
            // labelExecutor
            // 
            labelExecutor.AutoSize = true;
            labelExecutor.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            labelExecutor.ForeColor = Color.FromArgb(69, 21, 27);
            labelExecutor.Location = new Point(15, 331);
            labelExecutor.Name = "labelExecutor";
            labelExecutor.Size = new Size(116, 23);
            labelExecutor.TabIndex = 10;
            labelExecutor.Text = "Исполнитель";
            // 
            // labelPriority
            // 
            labelPriority.AutoSize = true;
            labelPriority.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            labelPriority.ForeColor = Color.FromArgb(69, 21, 27);
            labelPriority.Location = new Point(15, 448);
            labelPriority.Name = "labelPriority";
            labelPriority.Size = new Size(96, 23);
            labelPriority.TabIndex = 11;
            labelPriority.Text = "Приоритет";
            // 
            // buttonAddTask
            // 
            buttonAddTask.BackColor = Color.FromArgb(251, 222, 156);
            buttonAddTask.FlatStyle = FlatStyle.Popup;
            buttonAddTask.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonAddTask.ForeColor = Color.FromArgb(69, 21, 27);
            buttonAddTask.Location = new Point(284, 511);
            buttonAddTask.Name = "buttonAddTask";
            buttonAddTask.Size = new Size(185, 30);
            buttonAddTask.TabIndex = 12;
            buttonAddTask.Text = "Добавить задачу";
            buttonAddTask.UseVisualStyleBackColor = false;
            buttonAddTask.Click += buttonAddTask_Click;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 157, 174);
            ClientSize = new Size(482, 553);
            Controls.Add(buttonAddTask);
            Controls.Add(labelPriority);
            Controls.Add(labelExecutor);
            Controls.Add(labelEndDate);
            Controls.Add(labelStartDate);
            Controls.Add(labelDescription);
            Controls.Add(labelTitle);
            Controls.Add(dateTimeEnd);
            Controls.Add(dateTimeStart);
            Controls.Add(comboPriority);
            Controls.Add(comboExecutor);
            Controls.Add(textDescription);
            Controls.Add(textTitle);
            ForeColor = Color.FromArgb(69, 21, 27);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AddForm";
            Text = "Новая задача";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textTitle;
        private TextBox textDescription;
        private ComboBox comboExecutor;
        private ComboBox comboPriority;
        private DateTimePicker dateTimeStart;
        private DateTimePicker dateTimeEnd;
        private Label labelTitle;
        private Label labelDescription;
        private Label labelStartDate;
        private Label labelEndDate;
        private Label labelExecutor;
        private Label labelPriority;
        private Button buttonAddTask;
    }
}