namespace AppTasks
{
    partial class InfoForm
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
            checkDone = new CheckBox();
            buttonSave = new Button();
            SuspendLayout();
            // 
            // textTitle
            // 
            textTitle.BackColor = Color.FromArgb(251, 222, 156);
            textTitle.Font = new Font("Segoe UI", 11F);
            textTitle.ForeColor = Color.FromArgb(69, 21, 27);
            textTitle.Location = new Point(9, 35);
            textTitle.Multiline = true;
            textTitle.Name = "textTitle";
            textTitle.Size = new Size(484, 57);
            textTitle.TabIndex = 13;
            // 
            // textDescription
            // 
            textDescription.BackColor = Color.FromArgb(251, 222, 156);
            textDescription.Font = new Font("Segoe UI", 11F);
            textDescription.ForeColor = Color.FromArgb(69, 21, 27);
            textDescription.Location = new Point(9, 134);
            textDescription.Multiline = true;
            textDescription.Name = "textDescription";
            textDescription.Size = new Size(484, 218);
            textDescription.TabIndex = 14;
            // 
            // comboExecutor
            // 
            comboExecutor.BackColor = Color.FromArgb(251, 222, 156);
            comboExecutor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboExecutor.Font = new Font("Segoe UI", 11F);
            comboExecutor.ForeColor = Color.FromArgb(69, 21, 27);
            comboExecutor.FormattingEnabled = true;
            comboExecutor.Location = new Point(129, 376);
            comboExecutor.Name = "comboExecutor";
            comboExecutor.Size = new Size(364, 33);
            comboExecutor.TabIndex = 15;
            // 
            // comboPriority
            // 
            comboPriority.BackColor = Color.FromArgb(251, 222, 156);
            comboPriority.DropDownStyle = ComboBoxStyle.DropDownList;
            comboPriority.Font = new Font("Segoe UI", 11F);
            comboPriority.ForeColor = Color.FromArgb(69, 21, 27);
            comboPriority.FormattingEnabled = true;
            comboPriority.Items.AddRange(new object[] { "Низкий", "Средний", "Высокий" });
            comboPriority.Location = new Point(110, 504);
            comboPriority.Name = "comboPriority";
            comboPriority.Size = new Size(383, 33);
            comboPriority.TabIndex = 16;
            // 
            // dateTimeStart
            // 
            dateTimeStart.Font = new Font("Segoe UI", 11F);
            dateTimeStart.Location = new Point(8, 453);
            dateTimeStart.Name = "dateTimeStart";
            dateTimeStart.Size = new Size(240, 32);
            dateTimeStart.TabIndex = 17;
            // 
            // dateTimeEnd
            // 
            dateTimeEnd.Font = new Font("Segoe UI", 11F);
            dateTimeEnd.Location = new Point(253, 453);
            dateTimeEnd.Name = "dateTimeEnd";
            dateTimeEnd.Size = new Size(240, 32);
            dateTimeEnd.TabIndex = 18;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelTitle.ForeColor = Color.FromArgb(69, 21, 27);
            labelTitle.Location = new Point(9, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(87, 23);
            labelTitle.TabIndex = 19;
            labelTitle.Text = "Название";
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelDescription.ForeColor = Color.FromArgb(69, 21, 27);
            labelDescription.Location = new Point(9, 108);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(89, 23);
            labelDescription.TabIndex = 20;
            labelDescription.Text = "Описание";
            // 
            // labelStartDate
            // 
            labelStartDate.AutoSize = true;
            labelStartDate.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            labelStartDate.ForeColor = Color.FromArgb(69, 21, 27);
            labelStartDate.Location = new Point(8, 427);
            labelStartDate.Name = "labelStartDate";
            labelStartDate.Size = new Size(109, 23);
            labelStartDate.TabIndex = 21;
            labelStartDate.Text = "Дата начала";
            // 
            // labelEndDate
            // 
            labelEndDate.AutoSize = true;
            labelEndDate.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            labelEndDate.ForeColor = Color.FromArgb(69, 21, 27);
            labelEndDate.Location = new Point(254, 427);
            labelEndDate.Name = "labelEndDate";
            labelEndDate.Size = new Size(139, 23);
            labelEndDate.TabIndex = 22;
            labelEndDate.Text = "Дата окончания";
            // 
            // labelExecutor
            // 
            labelExecutor.AutoSize = true;
            labelExecutor.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelExecutor.ForeColor = Color.FromArgb(69, 21, 27);
            labelExecutor.Location = new Point(9, 376);
            labelExecutor.Name = "labelExecutor";
            labelExecutor.Size = new Size(116, 23);
            labelExecutor.TabIndex = 23;
            labelExecutor.Text = "Исполнитель";
            // 
            // labelPriority
            // 
            labelPriority.AutoSize = true;
            labelPriority.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelPriority.ForeColor = Color.FromArgb(69, 21, 27);
            labelPriority.Location = new Point(9, 504);
            labelPriority.Name = "labelPriority";
            labelPriority.Size = new Size(96, 23);
            labelPriority.TabIndex = 24;
            labelPriority.Text = "Приоритет";
            // 
            // checkDone
            // 
            checkDone.AutoSize = true;
            checkDone.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            checkDone.ForeColor = Color.FromArgb(69, 21, 27);
            checkDone.Location = new Point(15, 552);
            checkDone.Name = "checkDone";
            checkDone.Size = new Size(124, 27);
            checkDone.TabIndex = 25;
            checkDone.Text = "Выполнено";
            checkDone.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.FromArgb(251, 222, 156);
            buttonSave.FlatStyle = FlatStyle.Popup;
            buttonSave.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonSave.ForeColor = Color.FromArgb(69, 21, 27);
            buttonSave.Location = new Point(286, 552);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(207, 29);
            buttonSave.TabIndex = 26;
            buttonSave.Text = "Сохранить изменения";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // InfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 157, 174);
            ClientSize = new Size(506, 591);
            Controls.Add(buttonSave);
            Controls.Add(checkDone);
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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "InfoForm";
            Text = "Информация";
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
        private CheckBox checkDone;
        private Button buttonSave;
    }
}