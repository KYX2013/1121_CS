namespace Problem12
{
    partial class P12
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
            lblShow = new Label();
            txtYear = new TextBox();
            txtPerc = new TextBox();
            txtDoll = new TextBox();
            tryCal = new Button();
            calculator = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 10.8318586F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(40, 42);
            label1.Name = "label1";
            label1.Size = new Size(134, 22);
            label1.TabIndex = 0;
            label1.Text = "請輸入本金(元) : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 10.8318586F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label2.Location = new Point(40, 100);
            label2.Name = "label2";
            label2.Size = new Size(132, 22);
            label2.TabIndex = 1;
            label2.Text = "輸入年利率(%) : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 10.8318586F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label3.Location = new Point(40, 161);
            label3.Name = "label3";
            label3.Size = new Size(168, 22);
            label3.TabIndex = 2;
            label3.Text = "年後領回本利率(年) : ";
            // 
            // lblShow
            // 
            lblShow.AutoSize = true;
            lblShow.Font = new Font("Microsoft JhengHei UI", 10.8318586F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblShow.Location = new Point(40, 267);
            lblShow.Name = "lblShow";
            lblShow.Size = new Size(78, 22);
            lblShow.TabIndex = 3;
            lblShow.Text = "顯示區域";
            // 
            // txtYear
            // 
            txtYear.AllowDrop = true;
            txtYear.Anchor = AnchorStyles.None;
            txtYear.BorderStyle = BorderStyle.FixedSingle;
            txtYear.Location = new Point(214, 158);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(118, 25);
            txtYear.TabIndex = 3;
            // 
            // txtPerc
            // 
            txtPerc.AllowDrop = true;
            txtPerc.Anchor = AnchorStyles.None;
            txtPerc.BorderStyle = BorderStyle.FixedSingle;
            txtPerc.Location = new Point(214, 97);
            txtPerc.Name = "txtPerc";
            txtPerc.Size = new Size(118, 25);
            txtPerc.TabIndex = 2;
            // 
            // txtDoll
            // 
            txtDoll.AllowDrop = true;
            txtDoll.Anchor = AnchorStyles.None;
            txtDoll.BorderStyle = BorderStyle.FixedSingle;
            txtDoll.Location = new Point(214, 39);
            txtDoll.Name = "txtDoll";
            txtDoll.Size = new Size(118, 25);
            txtDoll.TabIndex = 1;
            // 
            // tryCal
            // 
            tryCal.FlatStyle = FlatStyle.Flat;
            tryCal.Font = new Font("Microsoft JhengHei UI", 10.8318586F, FontStyle.Regular, GraphicsUnit.Point, 136);
            tryCal.Location = new Point(384, 51);
            tryCal.Name = "tryCal";
            tryCal.Size = new Size(131, 42);
            tryCal.TabIndex = 4;
            tryCal.Text = "開啟試算";
            tryCal.UseVisualStyleBackColor = true;
            tryCal.Click += tryCal_Click;
            // 
            // calculator
            // 
            calculator.FlatStyle = FlatStyle.Flat;
            calculator.Font = new Font("Microsoft JhengHei UI", 10.8318586F, FontStyle.Regular, GraphicsUnit.Point, 136);
            calculator.Location = new Point(384, 121);
            calculator.Name = "calculator";
            calculator.Size = new Size(131, 42);
            calculator.TabIndex = 5;
            calculator.Text = "使用小算盤";
            calculator.UseVisualStyleBackColor = true;
            calculator.Click += calculator_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 363);
            Controls.Add(calculator);
            Controls.Add(tryCal);
            Controls.Add(txtDoll);
            Controls.Add(txtPerc);
            Controls.Add(txtYear);
            Controls.Add(lblShow);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmMain";
            Text = "複利率本利合試算";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblShow;
        private TextBox txtYear;
        private TextBox txtPerc;
        private TextBox txtDoll;
        private Button tryCal;
        private Button calculator;
    }
}
