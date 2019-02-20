namespace ITU.RefereeAssistant.WinDesktop
{
    partial class MatchControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSecond = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblFirst = new System.Windows.Forms.Label();
            this.numFirst = new System.Windows.Forms.NumericUpDown();
            this.numSecond = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFirst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSecond)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSecond.Location = new System.Drawing.Point(3, 27);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Padding = new System.Windows.Forms.Padding(4);
            this.lblSecond.Size = new System.Drawing.Size(94, 30);
            this.lblSecond.TabIndex = 5;
            this.lblSecond.Text = "label2";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblSecond, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblFirst, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.numFirst, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.numSecond, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(150, 57);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFirst.Location = new System.Drawing.Point(3, 0);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Padding = new System.Windows.Forms.Padding(4);
            this.lblFirst.Size = new System.Drawing.Size(94, 27);
            this.lblFirst.TabIndex = 9;
            this.lblFirst.Text = "label1";
            // 
            // numFirst
            // 
            this.numFirst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numFirst.Location = new System.Drawing.Point(103, 3);
            this.numFirst.Name = "numFirst";
            this.numFirst.Size = new System.Drawing.Size(44, 20);
            this.numFirst.TabIndex = 10;
            // 
            // numSecond
            // 
            this.numSecond.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numSecond.Location = new System.Drawing.Point(103, 30);
            this.numSecond.Name = "numSecond";
            this.numSecond.Size = new System.Drawing.Size(44, 20);
            this.numSecond.TabIndex = 11;
            // 
            // MatchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MatchControl";
            this.Size = new System.Drawing.Size(150, 57);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFirst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSecond)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.NumericUpDown numFirst;
        private System.Windows.Forms.NumericUpDown numSecond;
    }
}
