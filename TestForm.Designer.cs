namespace Test
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
            this.themeL = new System.Windows.Forms.Label();
            this.questionTB = new System.Windows.Forms.RichTextBox();
            this.questionL = new System.Windows.Forms.Label();
            this.answerGB = new System.Windows.Forms.GroupBox();
            this.fourthAnswerRB = new System.Windows.Forms.RadioButton();
            this.thirdAnswerRB = new System.Windows.Forms.RadioButton();
            this.secondAnswerRB = new System.Windows.Forms.RadioButton();
            this.firstAnswerRB = new System.Windows.Forms.RadioButton();
            this.nextMotionBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.answerGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // themeL
            // 
            this.themeL.AutoSize = true;
            this.themeL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.themeL.Location = new System.Drawing.Point(12, 9);
            this.themeL.Name = "themeL";
            this.themeL.Size = new System.Drawing.Size(137, 25);
            this.themeL.TabIndex = 0;
            this.themeL.Text = "Тема теста :";
            // 
            // questionTB
            // 
            this.questionTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionTB.Location = new System.Drawing.Point(17, 91);
            this.questionTB.Name = "questionTB";
            this.questionTB.ReadOnly = true;
            this.questionTB.Size = new System.Drawing.Size(801, 182);
            this.questionTB.TabIndex = 1;
            this.questionTB.Text = "";
            // 
            // questionL
            // 
            this.questionL.AutoSize = true;
            this.questionL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionL.Location = new System.Drawing.Point(12, 52);
            this.questionL.Name = "questionL";
            this.questionL.Size = new System.Drawing.Size(97, 25);
            this.questionL.TabIndex = 0;
            this.questionL.Text = "Вопрос :";
            // 
            // answerGB
            // 
            this.answerGB.Controls.Add(this.fourthAnswerRB);
            this.answerGB.Controls.Add(this.thirdAnswerRB);
            this.answerGB.Controls.Add(this.secondAnswerRB);
            this.answerGB.Controls.Add(this.firstAnswerRB);
            this.answerGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answerGB.Location = new System.Drawing.Point(17, 279);
            this.answerGB.Name = "answerGB";
            this.answerGB.Size = new System.Drawing.Size(801, 181);
            this.answerGB.TabIndex = 2;
            this.answerGB.TabStop = false;
            this.answerGB.Text = "Варианты ответа :";
            // 
            // fourthAnswerRB
            // 
            this.fourthAnswerRB.AutoSize = true;
            this.fourthAnswerRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fourthAnswerRB.Location = new System.Drawing.Point(21, 126);
            this.fourthAnswerRB.Name = "fourthAnswerRB";
            this.fourthAnswerRB.Size = new System.Drawing.Size(14, 13);
            this.fourthAnswerRB.TabIndex = 0;
            this.fourthAnswerRB.TabStop = true;
            this.fourthAnswerRB.Tag = "4";
            this.fourthAnswerRB.UseVisualStyleBackColor = true;
            // 
            // thirdAnswerRB
            // 
            this.thirdAnswerRB.AutoSize = true;
            this.thirdAnswerRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.thirdAnswerRB.Location = new System.Drawing.Point(21, 96);
            this.thirdAnswerRB.Name = "thirdAnswerRB";
            this.thirdAnswerRB.Size = new System.Drawing.Size(14, 13);
            this.thirdAnswerRB.TabIndex = 0;
            this.thirdAnswerRB.TabStop = true;
            this.thirdAnswerRB.Tag = "3";
            this.thirdAnswerRB.UseVisualStyleBackColor = true;
            // 
            // secondAnswerRB
            // 
            this.secondAnswerRB.AutoSize = true;
            this.secondAnswerRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondAnswerRB.Location = new System.Drawing.Point(21, 66);
            this.secondAnswerRB.Name = "secondAnswerRB";
            this.secondAnswerRB.Size = new System.Drawing.Size(14, 13);
            this.secondAnswerRB.TabIndex = 0;
            this.secondAnswerRB.TabStop = true;
            this.secondAnswerRB.Tag = "2";
            this.secondAnswerRB.UseVisualStyleBackColor = true;
            // 
            // firstAnswerRB
            // 
            this.firstAnswerRB.AutoSize = true;
            this.firstAnswerRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstAnswerRB.Location = new System.Drawing.Point(21, 36);
            this.firstAnswerRB.Name = "firstAnswerRB";
            this.firstAnswerRB.Size = new System.Drawing.Size(14, 13);
            this.firstAnswerRB.TabIndex = 0;
            this.firstAnswerRB.TabStop = true;
            this.firstAnswerRB.Tag = "1";
            this.firstAnswerRB.UseVisualStyleBackColor = true;
            // 
            // nextMotionBtn
            // 
            this.nextMotionBtn.Enabled = false;
            this.nextMotionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nextMotionBtn.Location = new System.Drawing.Point(602, 466);
            this.nextMotionBtn.Name = "nextMotionBtn";
            this.nextMotionBtn.Size = new System.Drawing.Size(216, 84);
            this.nextMotionBtn.TabIndex = 3;
            this.nextMotionBtn.Text = "Следующий вопрос";
            this.nextMotionBtn.UseVisualStyleBackColor = true;
            this.nextMotionBtn.Click += new System.EventHandler(this.nextMotionBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitBtn.Location = new System.Drawing.Point(38, 466);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(216, 84);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "Выйти";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 562);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.nextMotionBtn);
            this.Controls.Add(this.answerGB);
            this.Controls.Add(this.questionTB);
            this.Controls.Add(this.questionL);
            this.Controls.Add(this.themeL);
            this.Name = "TestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тест";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.exitBtn_Click);
            this.Load += new System.EventHandler(this.TestForm_Load);
            this.answerGB.ResumeLayout(false);
            this.answerGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label themeL;
        private System.Windows.Forms.RichTextBox questionTB;
        private System.Windows.Forms.Label questionL;
        private System.Windows.Forms.GroupBox answerGB;
        private System.Windows.Forms.Button nextMotionBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.RadioButton fourthAnswerRB;
        private System.Windows.Forms.RadioButton thirdAnswerRB;
        private System.Windows.Forms.RadioButton secondAnswerRB;
        private System.Windows.Forms.RadioButton firstAnswerRB;
    }
}