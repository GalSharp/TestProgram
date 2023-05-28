namespace Test
{
    partial class LeaderboardForm
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
            this.leaderBoardLB = new System.Windows.Forms.ListBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // leaderBoardLB
            // 
            this.leaderBoardLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leaderBoardLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leaderBoardLB.FormattingEnabled = true;
            this.leaderBoardLB.ItemHeight = 18;
            this.leaderBoardLB.Location = new System.Drawing.Point(12, 12);
            this.leaderBoardLB.Name = "leaderBoardLB";
            this.leaderBoardLB.Size = new System.Drawing.Size(585, 434);
            this.leaderBoardLB.TabIndex = 0;
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitBtn.Location = new System.Drawing.Point(12, 451);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(585, 90);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "Выход";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // LeaderboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 553);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.leaderBoardLB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LeaderboardForm";
            this.Text = "LeaderboardForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LeaderboardForm_FormClosed);
            this.Load += new System.EventHandler(this.LeaderboardForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox leaderBoardLB;
        private System.Windows.Forms.Button exitBtn;
    }
}