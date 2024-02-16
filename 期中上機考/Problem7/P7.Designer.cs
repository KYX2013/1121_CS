namespace Problem7
{
    partial class P7
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtFront = new System.Windows.Forms.TextBox();
            this.txtBack = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.answer = new System.Windows.Forms.Label();
            this.remove = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(497, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "如何在程式中新增自訂事件和移除自訂事件";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFront
            // 
            this.txtFront.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFront.Location = new System.Drawing.Point(108, 111);
            this.txtFront.Name = "txtFront";
            this.txtFront.Size = new System.Drawing.Size(100, 27);
            this.txtFront.TabIndex = 1;
            // 
            // txtBack
            // 
            this.txtBack.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBack.Location = new System.Drawing.Point(347, 111);
            this.txtBack.Name = "txtBack";
            this.txtBack.Size = new System.Drawing.Size(100, 27);
            this.txtBack.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.comboBox1.Location = new System.Drawing.Point(251, 111);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(59, 25);
            this.comboBox1.TabIndex = 3;
            // 
            // answer
            // 
            this.answer.AutoSize = true;
            this.answer.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer.Location = new System.Drawing.Point(484, 114);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(20, 20);
            this.answer.TabIndex = 4;
            this.answer.Text = "=";
            // 
            // remove
            // 
            this.remove.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove.Location = new System.Drawing.Point(193, 179);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(105, 40);
            this.remove.TabIndex = 5;
            this.remove.Text = "移除事件";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(429, 179);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(105, 40);
            this.add.TabIndex = 6;
            this.add.Text = "新增事件";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 262);
            this.Controls.Add(this.add);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtBack);
            this.Controls.Add(this.txtFront);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFront;
        private System.Windows.Forms.TextBox txtBack;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label answer;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button add;
    }
}

