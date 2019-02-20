namespace ITU.RefereeAssistant.WinDesktop
{
    partial class FormReferee
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
            this.cbTourType = new System.Windows.Forms.ComboBox();
            this.lblTourType = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnResetPlayer = new System.Windows.Forms.Button();
            this.gbPlayer = new System.Windows.Forms.GroupBox();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.btnAddPlayer = new System.Windows.Forms.Button();
            this.tbPlayerName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gbRound = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.matchControl1 = new ITU.RefereeAssistant.WinDesktop.MatchControl();
            this.gbPlayer.SuspendLayout();
            this.gbRound.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbTourType
            // 
            this.cbTourType.FormattingEnabled = true;
            this.cbTourType.Items.AddRange(new object[] {
            "Олимпийская",
            "Швейцарская"});
            this.cbTourType.Location = new System.Drawing.Point(15, 25);
            this.cbTourType.Name = "cbTourType";
            this.cbTourType.Size = new System.Drawing.Size(200, 21);
            this.cbTourType.TabIndex = 0;
            // 
            // lblTourType
            // 
            this.lblTourType.AutoSize = true;
            this.lblTourType.Location = new System.Drawing.Point(12, 9);
            this.lblTourType.Name = "lblTourType";
            this.lblTourType.Size = new System.Drawing.Size(125, 13);
            this.lblTourType.TabIndex = 1;
            this.lblTourType.Text = "Выберите тип системы";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(586, 347);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Старт";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnResetPlayer
            // 
            this.btnResetPlayer.Location = new System.Drawing.Point(667, 347);
            this.btnResetPlayer.Name = "btnResetPlayer";
            this.btnResetPlayer.Size = new System.Drawing.Size(75, 23);
            this.btnResetPlayer.TabIndex = 6;
            this.btnResetPlayer.Text = "Сбросить";
            this.btnResetPlayer.UseVisualStyleBackColor = true;
            // 
            // gbPlayer
            // 
            this.gbPlayer.Controls.Add(this.button1);
            this.gbPlayer.Location = new System.Drawing.Point(15, 103);
            this.gbPlayer.Name = "gbPlayer";
            this.gbPlayer.Size = new System.Drawing.Size(351, 238);
            this.gbPlayer.TabIndex = 7;
            this.gbPlayer.TabStop = false;
            this.gbPlayer.Text = "Список участник";
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(12, 61);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(307, 13);
            this.lblPlayerName.TabIndex = 2;
            this.lblPlayerName.Text = "Введите название команды и нажмите кнопку \"Добавить\"";
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.Location = new System.Drawing.Point(291, 77);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(75, 23);
            this.btnAddPlayer.TabIndex = 1;
            this.btnAddPlayer.Text = "Добавить";
            this.btnAddPlayer.UseVisualStyleBackColor = true;
            this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
            // 
            // tbPlayerName
            // 
            this.tbPlayerName.Location = new System.Drawing.Point(12, 77);
            this.tbPlayerName.Name = "tbPlayerName";
            this.tbPlayerName.Size = new System.Drawing.Size(273, 20);
            this.tbPlayerName.TabIndex = 0;
            this.tbPlayerName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbPlayerName_KeyUp);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(260, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // gbRound
            // 
            this.gbRound.Controls.Add(this.matchControl1);
            this.gbRound.Controls.Add(this.textBox1);
            this.gbRound.Controls.Add(this.label1);
            this.gbRound.Controls.Add(this.button2);
            this.gbRound.Location = new System.Drawing.Point(372, 25);
            this.gbRound.Name = "gbRound";
            this.gbRound.Size = new System.Drawing.Size(163, 316);
            this.gbRound.TabIndex = 8;
            this.gbRound.TabStop = false;
            this.gbRound.Text = "Раунд №1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(260, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(58, 134);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(34, 20);
            this.textBox1.TabIndex = 2;
            // 
            // matchControl1
            // 
            this.matchControl1.FirstPlayer = "label1";
            this.matchControl1.FirstScore = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.matchControl1.Location = new System.Drawing.Point(7, 19);
            this.matchControl1.Name = "matchControl1";
            this.matchControl1.SecondPlayer = "label2";
            this.matchControl1.SecondScore = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.matchControl1.Size = new System.Drawing.Size(150, 57);
            this.matchControl1.TabIndex = 3;
            // 
            // FormReferee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 377);
            this.Controls.Add(this.gbRound);
            this.Controls.Add(this.btnAddPlayer);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.tbPlayerName);
            this.Controls.Add(this.gbPlayer);
            this.Controls.Add(this.btnResetPlayer);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblTourType);
            this.Controls.Add(this.cbTourType);
            this.Name = "FormReferee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Помошник судьи";
            this.gbPlayer.ResumeLayout(false);
            this.gbRound.ResumeLayout(false);
            this.gbRound.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTourType;
        private System.Windows.Forms.Label lblTourType;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnResetPlayer;
        private System.Windows.Forms.GroupBox gbPlayer;
        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.TextBox tbPlayerName;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbRound;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private MatchControl matchControl1;
    }
}

