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
            this.cbTourType.Size = new System.Drawing.Size(351, 21);
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
            this.gbPlayer.Location = new System.Drawing.Point(372, 25);
            this.gbPlayer.Name = "gbPlayer";
            this.gbPlayer.Size = new System.Drawing.Size(370, 316);
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
            // FormReferee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 377);
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
    }
}

