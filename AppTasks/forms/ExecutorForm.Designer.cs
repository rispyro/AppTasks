namespace AppTasks
{
    partial class ExecutorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExecutorForm));
            label1 = new Label();
            textName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            dateTimeBirth = new DateTimePicker();
            buttonAddExecutor = new Button();
            comboGender = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.FromArgb(69, 21, 27);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(111, 23);
            label1.TabIndex = 0;
            label1.Text = "Введите имя";
            // 
            // textName
            // 
            textName.BackColor = Color.FromArgb(251, 222, 156);
            textName.Font = new Font("Microsoft Sans Serif", 10.2F);
            textName.ForeColor = Color.FromArgb(69, 21, 27);
            textName.Location = new Point(12, 32);
            textName.Name = "textName";
            textName.Size = new Size(251, 27);
            textName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.FromArgb(69, 21, 27);
            label2.Location = new Point(12, 75);
            label2.Name = "label2";
            label2.Size = new Size(78, 23);
            label2.TabIndex = 3;
            label2.Text = "Ваш пол";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.FromArgb(69, 21, 27);
            label3.Location = new Point(12, 142);
            label3.Name = "label3";
            label3.Size = new Size(133, 23);
            label3.TabIndex = 4;
            label3.Text = "Дата рождения";
            // 
            // dateTimeBirth
            // 
            dateTimeBirth.CalendarForeColor = Color.FromArgb(69, 21, 27);
            dateTimeBirth.CalendarMonthBackground = Color.FromArgb(251, 222, 156);
            dateTimeBirth.CalendarTitleBackColor = Color.FromArgb(251, 222, 156);
            dateTimeBirth.CalendarTitleForeColor = Color.FromArgb(69, 21, 27);
            dateTimeBirth.CustomFormat = "dd.MM.yyyy";
            dateTimeBirth.Font = new Font("Microsoft Sans Serif", 10.2F);
            dateTimeBirth.Location = new Point(12, 168);
            dateTimeBirth.MaxDate = new DateTime(2007, 1, 1, 0, 0, 0, 0);
            dateTimeBirth.MinDate = new DateTime(1907, 1, 1, 0, 0, 0, 0);
            dateTimeBirth.Name = "dateTimeBirth";
            dateTimeBirth.Size = new Size(251, 27);
            dateTimeBirth.TabIndex = 5;
            dateTimeBirth.Value = new DateTime(2007, 1, 1, 0, 0, 0, 0);
            // 
            // buttonAddExecutor
            // 
            buttonAddExecutor.BackColor = Color.FromArgb(251, 222, 156);
            buttonAddExecutor.FlatStyle = FlatStyle.Popup;
            buttonAddExecutor.Font = new Font("Segoe UI", 10F);
            buttonAddExecutor.ForeColor = Color.FromArgb(69, 21, 27);
            buttonAddExecutor.Location = new Point(74, 211);
            buttonAddExecutor.Name = "buttonAddExecutor";
            buttonAddExecutor.Size = new Size(124, 30);
            buttonAddExecutor.TabIndex = 6;
            buttonAddExecutor.Text = "Сохранить";
            buttonAddExecutor.UseVisualStyleBackColor = false;
            buttonAddExecutor.Click += buttonAddExecutor_Click;
            // 
            // comboGender
            // 
            comboGender.BackColor = Color.FromArgb(251, 222, 156);
            comboGender.DropDownStyle = ComboBoxStyle.DropDownList;
            comboGender.Font = new Font("Microsoft Sans Serif", 10.2F);
            comboGender.ForeColor = Color.FromArgb(69, 21, 27);
            comboGender.FormattingEnabled = true;
            comboGender.Items.AddRange(new object[] { "Мужской", "Женский" });
            comboGender.Location = new Point(12, 101);
            comboGender.Name = "comboGender";
            comboGender.Size = new Size(251, 28);
            comboGender.TabIndex = 7;
            // 
            // ExecutorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 157, 174);
            ClientSize = new Size(282, 253);
            Controls.Add(comboGender);
            Controls.Add(buttonAddExecutor);
            Controls.Add(dateTimeBirth);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ExecutorForm";
            Text = "Исполнитель";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textName;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimeBirth;
        private Button buttonAddExecutor;
        private ComboBox comboGender;
    }
}