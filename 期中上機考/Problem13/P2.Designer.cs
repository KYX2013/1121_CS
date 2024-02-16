namespace Problem13
{
    partial class P2
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
            pcLot1 = new CheckedListBox();
            pcLot2 = new CheckedListBox();
            info = new Label();
            claim = new Button();
            clear = new Button();
            exit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("微軟正黑體", 28.0353985F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label1.Location = new Point(37, 9);
            label1.Name = "label1";
            label1.Size = new Size(730, 56);
            label1.TabIndex = 0;
            label1.Text = "威力彩--請選擇6個號碼及1個特別號";
            // 
            // pcLot1
            // 
            pcLot1.CheckOnClick = true;
            pcLot1.Font = new Font("Microsoft YaHei UI", 15.2920361F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pcLot1.FormattingEnabled = true;
            pcLot1.IntegralHeight = false;
            pcLot1.Location = new Point(12, 68);
            pcLot1.MultiColumn = true;
            pcLot1.Name = "pcLot1";
            pcLot1.Size = new Size(776, 301);
            pcLot1.TabIndex = 1;
            // 
            // pcLot2
            // 
            pcLot2.CheckOnClick = true;
            pcLot2.Font = new Font("Microsoft YaHei UI", 15.2920361F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pcLot2.FormattingEnabled = true;
            pcLot2.Location = new Point(12, 382);
            pcLot2.MultiColumn = true;
            pcLot2.Name = "pcLot2";
            pcLot2.Size = new Size(776, 136);
            pcLot2.TabIndex = 2;
            // 
            // info
            // 
            info.AutoSize = true;
            info.Font = new Font("Microsoft YaHei UI", 12.1061945F, FontStyle.Bold, GraphicsUnit.Point, 0);
            info.Location = new Point(12, 534);
            info.Name = "info";
            info.Size = new Size(0, 26);
            info.TabIndex = 3;
            // 
            // claim
            // 
            claim.Font = new Font("微軟正黑體", 10.8318586F, FontStyle.Bold, GraphicsUnit.Point, 0);
            claim.Location = new Point(370, 637);
            claim.Name = "claim";
            claim.Size = new Size(100, 34);
            claim.TabIndex = 4;
            claim.Text = "對獎";
            claim.UseVisualStyleBackColor = true;
            claim.Click += claim_Click;
            // 
            // clear
            // 
            clear.Font = new Font("微軟正黑體", 10.8318586F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clear.Location = new Point(526, 637);
            clear.Name = "clear";
            clear.Size = new Size(100, 34);
            clear.TabIndex = 5;
            clear.Text = "清除";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // exit
            // 
            exit.Font = new Font("微軟正黑體", 10.8318586F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exit.Location = new Point(681, 637);
            exit.Name = "exit";
            exit.Size = new Size(100, 34);
            exit.TabIndex = 6;
            exit.Text = "結束";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 695);
            Controls.Add(exit);
            Controls.Add(clear);
            Controls.Add(claim);
            Controls.Add(info);
            Controls.Add(pcLot2);
            Controls.Add(pcLot1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckedListBox pcLot1;
        private CheckedListBox pcLot2;
        private Label info;
        private Button claim;
        private Button clear;
        private Button exit;
    }
}
