namespace MathematicalModelingTestByMidili.Forms
{
    partial class ResultForm
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
            this.closeBtn = new System.Windows.Forms.Button();
            this.wrongLbl = new System.Windows.Forms.Label();
            this.rightLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(36)))), ((int)(((byte)(0)))));
            this.closeBtn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeBtn.Location = new System.Drawing.Point(248, 313);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(173, 72);
            this.closeBtn.TabIndex = 3;
            this.closeBtn.Text = "ЗАКРЫТЬ";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // wrongLbl
            // 
            this.wrongLbl.AutoSize = true;
            this.wrongLbl.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrongLbl.Location = new System.Drawing.Point(109, 172);
            this.wrongLbl.Name = "wrongLbl";
            this.wrongLbl.Size = new System.Drawing.Size(272, 30);
            this.wrongLbl.TabIndex = 4;
            this.wrongLbl.Text = "Неправильных ответов: ";
            // 
            // rightLbl
            // 
            this.rightLbl.AutoSize = true;
            this.rightLbl.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightLbl.Location = new System.Drawing.Point(109, 50);
            this.rightLbl.Name = "rightLbl";
            this.rightLbl.Size = new System.Drawing.Size(249, 30);
            this.rightLbl.TabIndex = 5;
            this.rightLbl.Text = "Правильных ответов: ";
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(682, 423);
            this.Controls.Add(this.rightLbl);
            this.Controls.Add(this.wrongLbl);
            this.Controls.Add(this.closeBtn);
            this.Name = "ResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Результаты";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label wrongLbl;
        private System.Windows.Forms.Label rightLbl;
    }
}