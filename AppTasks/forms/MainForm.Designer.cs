namespace AppTasks
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            buttonNewExecutor = new Button();
            splitter1 = new Splitter();
            labelTasks = new Label();
            buttonInfo = new Button();
            buttonDelete = new Button();
            buttonAdd = new Button();
            dataGridTasks = new DataGridView();
            listExecutors = new ListBox();
            labelExecutors = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridTasks).BeginInit();
            SuspendLayout();
            // 
            // buttonNewExecutor
            // 
            buttonNewExecutor.BackColor = Color.FromArgb(251, 222, 156);
            buttonNewExecutor.FlatStyle = FlatStyle.Popup;
            buttonNewExecutor.Font = new Font("Segoe UI", 10F);
            buttonNewExecutor.ForeColor = Color.FromArgb(69, 21, 27);
            buttonNewExecutor.Location = new Point(575, 497);
            buttonNewExecutor.Name = "buttonNewExecutor";
            buttonNewExecutor.Size = new Size(199, 29);
            buttonNewExecutor.TabIndex = 5;
            buttonNewExecutor.Text = "Новый исполнитель";
            buttonNewExecutor.UseVisualStyleBackColor = false;
            buttonNewExecutor.Click += buttonNewExecutor_Click;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(565, 553);
            splitter1.TabIndex = 7;
            splitter1.TabStop = false;
            // 
            // labelTasks
            // 
            labelTasks.AutoSize = true;
            labelTasks.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelTasks.ForeColor = Color.FromArgb(69, 21, 27);
            labelTasks.Location = new Point(12, 12);
            labelTasks.Name = "labelTasks";
            labelTasks.Size = new Size(154, 31);
            labelTasks.TabIndex = 13;
            labelTasks.Text = "Ваши задачи";
            // 
            // buttonInfo
            // 
            buttonInfo.BackColor = Color.FromArgb(251, 222, 156);
            buttonInfo.FlatStyle = FlatStyle.Popup;
            buttonInfo.Font = new Font("Segoe UI", 10F);
            buttonInfo.ForeColor = Color.FromArgb(69, 21, 27);
            buttonInfo.Location = new Point(327, 497);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(120, 29);
            buttonInfo.TabIndex = 12;
            buttonInfo.Text = "Подробнее";
            buttonInfo.UseVisualStyleBackColor = false;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.FromArgb(251, 222, 156);
            buttonDelete.FlatStyle = FlatStyle.Popup;
            buttonDelete.Font = new Font("Segoe UI", 10F);
            buttonDelete.ForeColor = Color.FromArgb(69, 21, 27);
            buttonDelete.Location = new Point(453, 497);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 29);
            buttonDelete.TabIndex = 11;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.FromArgb(251, 222, 156);
            buttonAdd.FlatStyle = FlatStyle.Popup;
            buttonAdd.Font = new Font("Segoe UI", 10F);
            buttonAdd.ForeColor = Color.FromArgb(69, 21, 27);
            buttonAdd.Location = new Point(12, 497);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 9;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // dataGridTasks
            // 
            dataGridTasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridTasks.BackgroundColor = Color.FromArgb(234, 157, 174);
            dataGridTasks.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(251, 222, 156);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(68, 21, 27);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(249, 146, 86);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(68, 21, 27);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridTasks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(251, 222, 156);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(68, 21, 27);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(249, 146, 86);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(68, 21, 27);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridTasks.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridTasks.EnableHeadersVisualStyles = false;
            dataGridTasks.Location = new Point(12, 50);
            dataGridTasks.Name = "dataGridTasks";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(251, 222, 156);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(68, 21, 27);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(249, 146, 86);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(68, 21, 27);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridTasks.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridTasks.RowHeadersVisible = false;
            dataGridTasks.RowHeadersWidth = 51;
            dataGridTasks.Size = new Size(535, 428);
            dataGridTasks.TabIndex = 8;
            // 
            // listExecutors
            // 
            listExecutors.BackColor = Color.FromArgb(251, 222, 156);
            listExecutors.Font = new Font("Segoe UI", 10F);
            listExecutors.ForeColor = Color.FromArgb(69, 21, 27);
            listExecutors.FormattingEnabled = true;
            listExecutors.ItemHeight = 23;
            listExecutors.Location = new Point(571, 60);
            listExecutors.Name = "listExecutors";
            listExecutors.Size = new Size(199, 418);
            listExecutors.TabIndex = 14;
            // 
            // labelExecutors
            // 
            labelExecutors.AutoSize = true;
            labelExecutors.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelExecutors.ForeColor = Color.FromArgb(69, 21, 27);
            labelExecutors.Location = new Point(575, 23);
            labelExecutors.Name = "labelExecutors";
            labelExecutors.Size = new Size(161, 31);
            labelExecutors.TabIndex = 15;
            labelExecutors.Text = "Исполнители\r\n";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 157, 174);
            ClientSize = new Size(782, 553);
            Controls.Add(labelExecutors);
            Controls.Add(listExecutors);
            Controls.Add(labelTasks);
            Controls.Add(buttonInfo);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridTasks);
            Controls.Add(splitter1);
            Controls.Add(buttonNewExecutor);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Управление задачами";
            ((System.ComponentModel.ISupportInitialize)dataGridTasks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonNewExecutor;
        private Splitter splitter1;
        private Label labelTasks;
        private Button buttonInfo;
        private Button buttonDelete;
        private Button buttonAdd;
        private DataGridView dataGridTasks;
        private ListBox listExecutors;
        private Label labelExecutors;
    }
}
