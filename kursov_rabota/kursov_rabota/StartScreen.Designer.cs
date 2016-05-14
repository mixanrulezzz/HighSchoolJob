namespace kursov_rabota
{
    partial class StartScreen
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
            this.backup = new System.Windows.Forms.Button();
            this.report = new System.Windows.Forms.Button();
            this.create = new System.Windows.Forms.Button();
            this.change = new System.Windows.Forms.Button();
            this.deleteLine = new System.Windows.Forms.Button();
            this.PakingListButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backup
            // 
            this.backup.Location = new System.Drawing.Point(364, 262);
            this.backup.Name = "backup";
            this.backup.Size = new System.Drawing.Size(108, 23);
            this.backup.TabIndex = 0;
            this.backup.Text = "Резервная копия";
            this.backup.UseVisualStyleBackColor = true;
            this.backup.Click += new System.EventHandler(this.backup_Click);
            // 
            // report
            // 
            this.report.Location = new System.Drawing.Point(185, 216);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(103, 23);
            this.report.TabIndex = 1;
            this.report.Text = "Получить отчет";
            this.report.UseVisualStyleBackColor = true;
            this.report.Click += new System.EventHandler(this.report_Click);
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(185, 83);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(103, 23);
            this.create.TabIndex = 2;
            this.create.Text = "Добавление";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // change
            // 
            this.change.Location = new System.Drawing.Point(185, 112);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(103, 23);
            this.change.TabIndex = 3;
            this.change.Text = "Редактирование";
            this.change.UseVisualStyleBackColor = true;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // deleteLine
            // 
            this.deleteLine.Location = new System.Drawing.Point(185, 141);
            this.deleteLine.Name = "deleteLine";
            this.deleteLine.Size = new System.Drawing.Size(103, 23);
            this.deleteLine.TabIndex = 4;
            this.deleteLine.Text = "Удаление";
            this.deleteLine.UseVisualStyleBackColor = true;
            this.deleteLine.Click += new System.EventHandler(this.deleteLine_Click);
            // 
            // PakingListButton
            // 
            this.PakingListButton.Location = new System.Drawing.Point(160, 187);
            this.PakingListButton.Name = "PakingListButton";
            this.PakingListButton.Size = new System.Drawing.Size(151, 23);
            this.PakingListButton.TabIndex = 5;
            this.PakingListButton.Text = "Товарная накладная и чек";
            this.PakingListButton.UseVisualStyleBackColor = true;
            this.PakingListButton.Click += new System.EventHandler(this.PakingListButton_Click);
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 297);
            this.Controls.Add(this.PakingListButton);
            this.Controls.Add(this.deleteLine);
            this.Controls.Add(this.change);
            this.Controls.Add(this.create);
            this.Controls.Add(this.report);
            this.Controls.Add(this.backup);
            this.Name = "StartScreen";
            this.Text = "Программа";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StartScreen_FormClosing);
            this.Load += new System.EventHandler(this.StartScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backup;
        private System.Windows.Forms.Button report;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.Button deleteLine;
        private System.Windows.Forms.Button PakingListButton;
    }
}

