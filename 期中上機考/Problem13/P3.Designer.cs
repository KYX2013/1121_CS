namespace Problem13
{
    partial class P3
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
            label1 = new Label();
            checkedListBox1 = new CheckedListBox();
            label2 = new Label();
            label3 = new Label();
            monthCalendar1 = new MonthCalendar();
            richTextBox1 = new RichTextBox();
            OK = new Button();
            Again = new Button();
            Open = new Button();
            Save = new Button();
            End = new Button();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 10.8318586F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 15);
            label1.Name = "label1";
            label1.Size = new Size(146, 24);
            label1.TabIndex = 0;
            label1.Text = "請勾選預購的產品";
            // 
            // checkedListBox1
            // 
            checkedListBox1.CheckOnClick = true;
            checkedListBox1.ColumnWidth = 218;
            checkedListBox1.Font = new Font("Microsoft YaHei UI", 10.1946907F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "吹風機", "捕蚊燈", "吸塵器", "濾水壺", "冰箱", "液晶電視", "DC扇", "滾筒洗衣機", "掃地機器人", "除濕器", "電鍋", "微波爐" });
            checkedListBox1.Location = new Point(18, 46);
            checkedListBox1.MultiColumn = true;
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(876, 96);
            checkedListBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 10.8318586F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 177);
            label2.Name = "label2";
            label2.Size = new Size(129, 24);
            label2.TabIndex = 2;
            label2.Text = "請指定取貨日期";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 10.8318586F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(308, 177);
            label3.Name = "label3";
            label3.Size = new Size(163, 24);
            label3.TabIndex = 3;
            label3.Text = "預購明細及取貨日期";
            // 
            // monthCalendar1
            // 
            monthCalendar1.BackColor = SystemColors.Desktop;
            monthCalendar1.Font = new Font("Microsoft JhengHei UI", 8.920354F, FontStyle.Bold, GraphicsUnit.Point, 136);
            monthCalendar1.ForeColor = SystemColors.HotTrack;
            monthCalendar1.Location = new Point(18, 210);
            monthCalendar1.MaxSelectionCount = 100;
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 4;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(308, 210);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(586, 189);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // OK
            // 
            OK.FlatAppearance.BorderSize = 5;
            OK.Font = new Font("Microsoft YaHei UI", 10.8318586F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OK.Location = new Point(18, 421);
            OK.Name = "OK";
            OK.Size = new Size(88, 45);
            OK.TabIndex = 6;
            OK.Text = "確定";
            OK.UseVisualStyleBackColor = true;
            OK.Click += OK_Click;
            // 
            // Again
            // 
            Again.FlatAppearance.BorderSize = 5;
            Again.Font = new Font("Microsoft YaHei UI", 10.8318586F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Again.Location = new Point(200, 421);
            Again.Name = "Again";
            Again.Size = new Size(88, 45);
            Again.TabIndex = 7;
            Again.Text = "重選";
            Again.UseVisualStyleBackColor = true;
            Again.Click += Again_Click;
            // 
            // Open
            // 
            Open.FlatAppearance.BorderSize = 5;
            Open.Font = new Font("Microsoft YaHei UI", 10.8318586F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Open.Location = new Point(403, 421);
            Open.Name = "Open";
            Open.Size = new Size(88, 45);
            Open.TabIndex = 8;
            Open.Text = "開檔";
            Open.UseVisualStyleBackColor = true;
            Open.Click += Open_Click;
            // 
            // Save
            // 
            Save.FlatAppearance.BorderSize = 5;
            Save.Font = new Font("Microsoft YaHei UI", 10.8318586F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Save.Location = new Point(613, 421);
            Save.Name = "Save";
            Save.Size = new Size(88, 45);
            Save.TabIndex = 9;
            Save.Text = "存檔";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // End
            // 
            End.FlatAppearance.BorderSize = 5;
            End.Font = new Font("Microsoft YaHei UI", 10.8318586F, FontStyle.Regular, GraphicsUnit.Point, 0);
            End.Location = new Point(806, 421);
            End.Name = "End";
            End.Size = new Size(88, 45);
            End.TabIndex = 10;
            End.Text = "結束";
            End.UseVisualStyleBackColor = true;
            End.Click += End_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 478);
            Controls.Add(End);
            Controls.Add(Save);
            Controls.Add(Open);
            Controls.Add(Again);
            Controls.Add(OK);
            Controls.Add(richTextBox1);
            Controls.Add(monthCalendar1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(checkedListBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckedListBox checkedListBox1;
        private Label label2;
        private Label label3;
        private MonthCalendar monthCalendar1;
        private RichTextBox richTextBox1;
        private Button OK;
        private Button Again;
        private Button Open;
        private Button Save;
        private Button End;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}
