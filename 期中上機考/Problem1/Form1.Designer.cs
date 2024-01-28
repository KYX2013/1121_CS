namespace Problem1
{
    partial class Form1
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            Id = new ComboBox();
            StudentName = new ComboBox();
            BirthYear = new ComboBox();
            BirthMon = new ComboBox();
            BirthDay = new ComboBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            Club = new ListBox();
            Add = new Button();
            End = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("微軟正黑體", 19.7522125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 22);
            label1.Name = "label1";
            label1.Size = new Size(265, 39);
            label1.TabIndex = 0;
            label1.Text = "學員資料登錄作業";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 10.8318586F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 81);
            label2.Name = "label2";
            label2.Size = new Size(54, 24);
            label2.TabIndex = 1;
            label2.Text = "學號: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 10.8318586F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 132);
            label3.Name = "label3";
            label3.Size = new Size(54, 24);
            label3.TabIndex = 2;
            label3.Text = "姓名: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 10.8318586F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(24, 184);
            label4.Name = "label4";
            label4.Size = new Size(540, 24);
            label4.TabIndex = 3;
            label4.Text = "生日:                                         年                        月                       日";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei UI", 10.8318586F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(24, 240);
            label5.Name = "label5";
            label5.Size = new Size(54, 24);
            label5.TabIndex = 4;
            label5.Text = "性別: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft YaHei UI", 10.8318586F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(24, 299);
            label6.Name = "label6";
            label6.Size = new Size(54, 24);
            label6.TabIndex = 5;
            label6.Text = "社團: ";
            // 
            // Id
            // 
            Id.FormattingEnabled = true;
            Id.Location = new Point(99, 81);
            Id.Name = "Id";
            Id.Size = new Size(190, 26);
            Id.TabIndex = 6;
            // 
            // StudentName
            // 
            StudentName.FormattingEnabled = true;
            StudentName.Location = new Point(99, 132);
            StudentName.Name = "StudentName";
            StudentName.Size = new Size(190, 26);
            StudentName.TabIndex = 7;
            // 
            // BirthYear
            // 
            BirthYear.FormattingEnabled = true;
            BirthYear.Location = new Point(99, 185);
            BirthYear.Name = "BirthYear";
            BirthYear.Size = new Size(147, 26);
            BirthYear.TabIndex = 8;
            // 
            // BirthMon
            // 
            BirthMon.FormattingEnabled = true;
            BirthMon.Location = new Point(307, 185);
            BirthMon.Name = "BirthMon";
            BirthMon.Size = new Size(89, 26);
            BirthMon.TabIndex = 9;
            // 
            // BirthDay
            // 
            BirthDay.FormattingEnabled = true;
            BirthDay.Location = new Point(440, 184);
            BirthDay.Name = "BirthDay";
            BirthDay.Size = new Size(89, 26);
            BirthDay.TabIndex = 10;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Microsoft YaHei UI", 10.8318586F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton1.Location = new Point(99, 238);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(45, 28);
            radioButton1.TabIndex = 11;
            radioButton1.TabStop = true;
            radioButton1.Text = "男";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Microsoft YaHei UI", 10.8318586F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton2.Location = new Point(182, 240);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(45, 28);
            radioButton2.TabIndex = 12;
            radioButton2.TabStop = true;
            radioButton2.Text = "女";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // Club
            // 
            Club.Font = new Font("Microsoft YaHei UI", 10.8318586F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Club.FormattingEnabled = true;
            Club.ItemHeight = 24;
            Club.Location = new Point(99, 299);
            Club.Name = "Club";
            Club.Size = new Size(282, 172);
            Club.TabIndex = 13;
            // 
            // Add
            // 
            Add.Cursor = Cursors.Hand;
            Add.FlatStyle = FlatStyle.Flat;
            Add.Font = new Font("Microsoft YaHei UI", 12.1061945F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Add.Location = new Point(476, 322);
            Add.Name = "Add";
            Add.Size = new Size(102, 51);
            Add.TabIndex = 14;
            Add.Text = "新增";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // End
            // 
            End.Cursor = Cursors.Hand;
            End.FlatStyle = FlatStyle.Flat;
            End.Font = new Font("Microsoft YaHei UI", 12.1061945F, FontStyle.Bold, GraphicsUnit.Point, 0);
            End.Location = new Point(476, 401);
            End.Name = "End";
            End.Size = new Size(102, 51);
            End.TabIndex = 15;
            End.Text = "結束";
            End.UseVisualStyleBackColor = true;
            End.Click += End_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 491);
            Controls.Add(End);
            Controls.Add(Add);
            Controls.Add(Club);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(BirthDay);
            Controls.Add(BirthMon);
            Controls.Add(BirthYear);
            Controls.Add(StudentName);
            Controls.Add(Id);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox Id;
        private ComboBox StudentName;
        private ComboBox BirthYear;
        private ComboBox BirthMon;
        private ComboBox BirthDay;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private ListBox Club;
        private Button Add;
        private Button End;
    }
}
