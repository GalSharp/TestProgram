namespace Test
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.firstNameL = new System.Windows.Forms.Label();
            this.lastNameL = new System.Windows.Forms.Label();
            this.firstNameTB = new System.Windows.Forms.TextBox();
            this.lastNameTB = new System.Windows.Forms.TextBox();
            this.groupCB = new System.Windows.Forms.ComboBox();
            this.groupL = new System.Windows.Forms.Label();
            this.startTestBtn = new System.Windows.Forms.Button();
            this.invalideInputL = new System.Windows.Forms.Label();
            this.leaderBoardBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNameL
            // 
            this.firstNameL.AutoSize = true;
            this.firstNameL.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNameL.Location = new System.Drawing.Point(43, 9);
            this.firstNameL.Name = "firstNameL";
            this.firstNameL.Size = new System.Drawing.Size(63, 29);
            this.firstNameL.TabIndex = 0;
            this.firstNameL.Text = "Имя";
            // 
            // lastNameL
            // 
            this.lastNameL.AutoSize = true;
            this.lastNameL.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastNameL.Location = new System.Drawing.Point(253, 9);
            this.lastNameL.Name = "lastNameL";
            this.lastNameL.Size = new System.Drawing.Size(125, 29);
            this.lastNameL.TabIndex = 0;
            this.lastNameL.Text = "Фамилия";
            // 
            // firstNameTB
            // 
            this.firstNameTB.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNameTB.Location = new System.Drawing.Point(12, 50);
            this.firstNameTB.Multiline = true;
            this.firstNameTB.Name = "firstNameTB";
            this.firstNameTB.Size = new System.Drawing.Size(183, 55);
            this.firstNameTB.TabIndex = 1;
            this.firstNameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lastNameTB
            // 
            this.lastNameTB.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastNameTB.Location = new System.Drawing.Point(219, 50);
            this.lastNameTB.Multiline = true;
            this.lastNameTB.Name = "lastNameTB";
            this.lastNameTB.Size = new System.Drawing.Size(182, 55);
            this.lastNameTB.TabIndex = 1;
            this.lastNameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupCB
            // 
            this.groupCB.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupCB.FormattingEnabled = true;
            this.groupCB.Items.AddRange(new object[] {
            "ИС 1-21",
            "ИС 2-21",
            "ИС 3-21",
            "ИС 1-22",
            "ИС 2-22",
            "ИС 3-22",
            "ИС 4-22"});
            this.groupCB.Location = new System.Drawing.Point(136, 176);
            this.groupCB.Name = "groupCB";
            this.groupCB.Size = new System.Drawing.Size(121, 37);
            this.groupCB.TabIndex = 2;
            // 
            // groupL
            // 
            this.groupL.AutoSize = true;
            this.groupL.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupL.Location = new System.Drawing.Point(149, 133);
            this.groupL.Name = "groupL";
            this.groupL.Size = new System.Drawing.Size(97, 29);
            this.groupL.TabIndex = 0;
            this.groupL.Text = "Группа";
            // 
            // startTestBtn
            // 
            this.startTestBtn.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startTestBtn.Location = new System.Drawing.Point(234, 299);
            this.startTestBtn.Name = "startTestBtn";
            this.startTestBtn.Size = new System.Drawing.Size(144, 69);
            this.startTestBtn.TabIndex = 3;
            this.startTestBtn.Text = "Начать тест";
            this.startTestBtn.UseVisualStyleBackColor = true;
            this.startTestBtn.Click += new System.EventHandler(this.startTestBtn_Click);
            // 
            // invalideInputL
            // 
            this.invalideInputL.AutoSize = true;
            this.invalideInputL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.invalideInputL.ForeColor = System.Drawing.Color.Red;
            this.invalideInputL.Location = new System.Drawing.Point(110, 239);
            this.invalideInputL.Name = "invalideInputL";
            this.invalideInputL.Size = new System.Drawing.Size(189, 24);
            this.invalideInputL.TabIndex = 4;
            this.invalideInputL.Text = "заполните все поля";
            this.invalideInputL.Visible = false;
            // 
            // leaderBoardBtn
            // 
            this.leaderBoardBtn.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leaderBoardBtn.Location = new System.Drawing.Point(21, 299);
            this.leaderBoardBtn.Name = "leaderBoardBtn";
            this.leaderBoardBtn.Size = new System.Drawing.Size(144, 69);
            this.leaderBoardBtn.TabIndex = 3;
            this.leaderBoardBtn.Text = "Рейтинг";
            this.leaderBoardBtn.UseVisualStyleBackColor = true;
            this.leaderBoardBtn.Click += new System.EventHandler(this.leaderBoardBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 399);
            this.Controls.Add(this.invalideInputL);
            this.Controls.Add(this.leaderBoardBtn);
            this.Controls.Add(this.startTestBtn);
            this.Controls.Add(this.groupCB);
            this.Controls.Add(this.lastNameTB);
            this.Controls.Add(this.firstNameTB);
            this.Controls.Add(this.lastNameL);
            this.Controls.Add(this.groupL);
            this.Controls.Add(this.firstNameL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameL;
        private System.Windows.Forms.Label lastNameL;
        private System.Windows.Forms.TextBox firstNameTB;
        private System.Windows.Forms.TextBox lastNameTB;
        private System.Windows.Forms.ComboBox groupCB;
        private System.Windows.Forms.Label groupL;
        private System.Windows.Forms.Button startTestBtn;
        private System.Windows.Forms.Label invalideInputL;
        private System.Windows.Forms.Button leaderBoardBtn;
    }
}

