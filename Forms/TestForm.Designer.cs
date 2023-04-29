namespace MathematicalModelingTestByMidili.Forms
{
    partial class TestForm
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
            this.titleLbl = new System.Windows.Forms.Label();
            this.ans1 = new System.Windows.Forms.RadioButton();
            this.ans2 = new System.Windows.Forms.RadioButton();
            this.ans3 = new System.Windows.Forms.RadioButton();
            this.ans4 = new System.Windows.Forms.RadioButton();
            this.nextBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(41, 9);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(35, 30);
            this.titleLbl.TabIndex = 1;
            this.titleLbl.Text = "1.";
            // 
            // ans1
            // 
            this.ans1.AutoSize = true;
            this.ans1.BackColor = System.Drawing.Color.White;
            this.ans1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ans1.Location = new System.Drawing.Point(46, 94);
            this.ans1.Name = "ans1";
            this.ans1.Size = new System.Drawing.Size(14, 13);
            this.ans1.TabIndex = 2;
            this.ans1.TabStop = true;
            this.ans1.UseVisualStyleBackColor = false;
            // 
            // ans2
            // 
            this.ans2.AutoSize = true;
            this.ans2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ans2.Location = new System.Drawing.Point(46, 156);
            this.ans2.Name = "ans2";
            this.ans2.Size = new System.Drawing.Size(14, 13);
            this.ans2.TabIndex = 3;
            this.ans2.TabStop = true;
            this.ans2.UseVisualStyleBackColor = true;
            // 
            // ans3
            // 
            this.ans3.AutoSize = true;
            this.ans3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ans3.Location = new System.Drawing.Point(46, 218);
            this.ans3.Name = "ans3";
            this.ans3.Size = new System.Drawing.Size(14, 13);
            this.ans3.TabIndex = 4;
            this.ans3.TabStop = true;
            this.ans3.UseVisualStyleBackColor = true;
            // 
            // ans4
            // 
            this.ans4.AutoSize = true;
            this.ans4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ans4.Location = new System.Drawing.Point(46, 285);
            this.ans4.Name = "ans4";
            this.ans4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ans4.Size = new System.Drawing.Size(14, 13);
            this.ans4.TabIndex = 5;
            this.ans4.TabStop = true;
            this.ans4.UseVisualStyleBackColor = true;
            // 
            // nextBtn
            // 
            this.nextBtn.BackColor = System.Drawing.Color.White;
            this.nextBtn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nextBtn.Location = new System.Drawing.Point(267, 365);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(141, 46);
            this.nextBtn.TabIndex = 6;
            this.nextBtn.Text = "ПРОВЕРИТЬ";
            this.nextBtn.UseVisualStyleBackColor = false;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(682, 423);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.ans4);
            this.Controls.Add(this.ans3);
            this.Controls.Add(this.ans2);
            this.Controls.Add(this.ans1);
            this.Controls.Add(this.titleLbl);
            this.Name = "TestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тест";
            this.Load += new System.EventHandler(this.TestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.RadioButton ans1;
        private System.Windows.Forms.RadioButton ans2;
        private System.Windows.Forms.RadioButton ans3;
        private System.Windows.Forms.RadioButton ans4;
        private System.Windows.Forms.Button nextBtn;
    }
}