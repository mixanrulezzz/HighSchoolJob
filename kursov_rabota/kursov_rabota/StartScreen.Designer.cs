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
            this.report = new System.Windows.Forms.Button();
            this.PakingListButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.работаСБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShipmentCreateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientCreateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProviderCreateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProviderShipmentCreateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PurchaseHistoryCreateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShipmentUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProviderUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProviderShipmentUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PurchaseHistoryUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShipmentDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProviderDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProviderShipmentDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PurchaseHistoryDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PackingListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CheckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SFD = new System.Windows.Forms.SaveFileDialog();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.работаСБДToolStripMenuItem,
            this.OptToolStripMenuItem,
            this.ReportToolStripMenuItem,
            this.BackupToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // работаСБДToolStripMenuItem
            // 
            this.работаСБДToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateToolStripMenuItem,
            this.UpdateToolStripMenuItem,
            this.DeleteToolStripMenuItem});
            this.работаСБДToolStripMenuItem.Name = "работаСБДToolStripMenuItem";
            this.работаСБДToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.работаСБДToolStripMenuItem.Text = "Работа с БД";
            // 
            // CreateToolStripMenuItem
            // 
            this.CreateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShipmentCreateToolStripMenuItem,
            this.ClientCreateToolStripMenuItem,
            this.ProviderCreateToolStripMenuItem,
            this.ProviderShipmentCreateToolStripMenuItem,
            this.PurchaseHistoryCreateToolStripMenuItem});
            this.CreateToolStripMenuItem.Name = "CreateToolStripMenuItem";
            this.CreateToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.CreateToolStripMenuItem.Text = "Добавление в таблицу";
            // 
            // ShipmentCreateToolStripMenuItem
            // 
            this.ShipmentCreateToolStripMenuItem.Name = "ShipmentCreateToolStripMenuItem";
            this.ShipmentCreateToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.ShipmentCreateToolStripMenuItem.Text = "Товар";
            this.ShipmentCreateToolStripMenuItem.Click += new System.EventHandler(this.ShipmentCreateToolStripMenuItem_Click);
            // 
            // ClientCreateToolStripMenuItem
            // 
            this.ClientCreateToolStripMenuItem.Name = "ClientCreateToolStripMenuItem";
            this.ClientCreateToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.ClientCreateToolStripMenuItem.Text = "Клиент";
            this.ClientCreateToolStripMenuItem.Click += new System.EventHandler(this.ClientCreateToolStripMenuItem_Click);
            // 
            // ProviderCreateToolStripMenuItem
            // 
            this.ProviderCreateToolStripMenuItem.Name = "ProviderCreateToolStripMenuItem";
            this.ProviderCreateToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.ProviderCreateToolStripMenuItem.Text = "Поставщик";
            this.ProviderCreateToolStripMenuItem.Click += new System.EventHandler(this.ProviderCreateToolStripMenuItem_Click);
            // 
            // ProviderShipmentCreateToolStripMenuItem
            // 
            this.ProviderShipmentCreateToolStripMenuItem.Name = "ProviderShipmentCreateToolStripMenuItem";
            this.ProviderShipmentCreateToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.ProviderShipmentCreateToolStripMenuItem.Text = "Поставщик-Товар";
            this.ProviderShipmentCreateToolStripMenuItem.Click += new System.EventHandler(this.ProviderShipmentCreateToolStripMenuItem_Click);
            // 
            // PurchaseHistoryCreateToolStripMenuItem
            // 
            this.PurchaseHistoryCreateToolStripMenuItem.Name = "PurchaseHistoryCreateToolStripMenuItem";
            this.PurchaseHistoryCreateToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.PurchaseHistoryCreateToolStripMenuItem.Text = "История покупок";
            this.PurchaseHistoryCreateToolStripMenuItem.Click += new System.EventHandler(this.PurchaseHistoryCreateToolStripMenuItem_Click);
            // 
            // UpdateToolStripMenuItem
            // 
            this.UpdateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShipmentUpdateToolStripMenuItem,
            this.ClientUpdateToolStripMenuItem,
            this.ProviderUpdateToolStripMenuItem,
            this.ProviderShipmentUpdateToolStripMenuItem,
            this.PurchaseHistoryUpdateToolStripMenuItem});
            this.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem";
            this.UpdateToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.UpdateToolStripMenuItem.Text = "Редактирование таблицы";
            // 
            // ShipmentUpdateToolStripMenuItem
            // 
            this.ShipmentUpdateToolStripMenuItem.Name = "ShipmentUpdateToolStripMenuItem";
            this.ShipmentUpdateToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.ShipmentUpdateToolStripMenuItem.Text = "Товар";
            this.ShipmentUpdateToolStripMenuItem.Click += new System.EventHandler(this.ShipmentUpdateToolStripMenuItem_Click);
            // 
            // ClientUpdateToolStripMenuItem
            // 
            this.ClientUpdateToolStripMenuItem.Name = "ClientUpdateToolStripMenuItem";
            this.ClientUpdateToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.ClientUpdateToolStripMenuItem.Text = "Клиент";
            this.ClientUpdateToolStripMenuItem.Click += new System.EventHandler(this.ClientUpdateToolStripMenuItem_Click);
            // 
            // ProviderUpdateToolStripMenuItem
            // 
            this.ProviderUpdateToolStripMenuItem.Name = "ProviderUpdateToolStripMenuItem";
            this.ProviderUpdateToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.ProviderUpdateToolStripMenuItem.Text = "Поставщик";
            this.ProviderUpdateToolStripMenuItem.Click += new System.EventHandler(this.ProviderUpdateToolStripMenuItem_Click);
            // 
            // ProviderShipmentUpdateToolStripMenuItem
            // 
            this.ProviderShipmentUpdateToolStripMenuItem.Name = "ProviderShipmentUpdateToolStripMenuItem";
            this.ProviderShipmentUpdateToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.ProviderShipmentUpdateToolStripMenuItem.Text = "Поставщик-Товар";
            this.ProviderShipmentUpdateToolStripMenuItem.Click += new System.EventHandler(this.ProviderShipmentUpdateToolStripMenuItem_Click);
            // 
            // PurchaseHistoryUpdateToolStripMenuItem
            // 
            this.PurchaseHistoryUpdateToolStripMenuItem.Name = "PurchaseHistoryUpdateToolStripMenuItem";
            this.PurchaseHistoryUpdateToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.PurchaseHistoryUpdateToolStripMenuItem.Text = "История покупок";
            this.PurchaseHistoryUpdateToolStripMenuItem.Click += new System.EventHandler(this.PurchaseHistoryUpdateToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShipmentDeleteToolStripMenuItem,
            this.ClientDeleteToolStripMenuItem,
            this.ProviderDeleteToolStripMenuItem,
            this.ProviderShipmentDeleteToolStripMenuItem,
            this.PurchaseHistoryDeleteToolStripMenuItem});
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.DeleteToolStripMenuItem.Text = "Удаление из таблицы";
            // 
            // ShipmentDeleteToolStripMenuItem
            // 
            this.ShipmentDeleteToolStripMenuItem.Name = "ShipmentDeleteToolStripMenuItem";
            this.ShipmentDeleteToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.ShipmentDeleteToolStripMenuItem.Text = "Товар";
            this.ShipmentDeleteToolStripMenuItem.Click += new System.EventHandler(this.ShipmentDeleteToolStripMenuItem_Click);
            // 
            // ClientDeleteToolStripMenuItem
            // 
            this.ClientDeleteToolStripMenuItem.Name = "ClientDeleteToolStripMenuItem";
            this.ClientDeleteToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.ClientDeleteToolStripMenuItem.Text = "Клиент";
            this.ClientDeleteToolStripMenuItem.Click += new System.EventHandler(this.ClientDeleteToolStripMenuItem_Click);
            // 
            // ProviderDeleteToolStripMenuItem
            // 
            this.ProviderDeleteToolStripMenuItem.Name = "ProviderDeleteToolStripMenuItem";
            this.ProviderDeleteToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.ProviderDeleteToolStripMenuItem.Text = "Поставщик";
            this.ProviderDeleteToolStripMenuItem.Click += new System.EventHandler(this.ProviderDeleteToolStripMenuItem_Click);
            // 
            // ProviderShipmentDeleteToolStripMenuItem
            // 
            this.ProviderShipmentDeleteToolStripMenuItem.Name = "ProviderShipmentDeleteToolStripMenuItem";
            this.ProviderShipmentDeleteToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.ProviderShipmentDeleteToolStripMenuItem.Text = "Поставщик-Товар";
            this.ProviderShipmentDeleteToolStripMenuItem.Click += new System.EventHandler(this.ProviderShipmentDeleteToolStripMenuItem_Click);
            // 
            // PurchaseHistoryDeleteToolStripMenuItem
            // 
            this.PurchaseHistoryDeleteToolStripMenuItem.Name = "PurchaseHistoryDeleteToolStripMenuItem";
            this.PurchaseHistoryDeleteToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.PurchaseHistoryDeleteToolStripMenuItem.Text = "История покупок";
            this.PurchaseHistoryDeleteToolStripMenuItem.Click += new System.EventHandler(this.PurchaseHistoryDeleteToolStripMenuItem_Click);
            // 
            // OptToolStripMenuItem
            // 
            this.OptToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PackingListToolStripMenuItem,
            this.CheckToolStripMenuItem});
            this.OptToolStripMenuItem.Name = "OptToolStripMenuItem";
            this.OptToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.OptToolStripMenuItem.Text = "Для оптовиков";
            // 
            // PackingListToolStripMenuItem
            // 
            this.PackingListToolStripMenuItem.Name = "PackingListToolStripMenuItem";
            this.PackingListToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.PackingListToolStripMenuItem.Text = "Товарная накладная";
            // 
            // CheckToolStripMenuItem
            // 
            this.CheckToolStripMenuItem.Name = "CheckToolStripMenuItem";
            this.CheckToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.CheckToolStripMenuItem.Text = "Чек";
            // 
            // ReportToolStripMenuItem
            // 
            this.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem";
            this.ReportToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.ReportToolStripMenuItem.Text = "Отчеты";
            // 
            // BackupToolStripMenuItem
            // 
            this.BackupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateBackupToolStripMenuItem,
            this.LoadBackupToolStripMenuItem});
            this.BackupToolStripMenuItem.Name = "BackupToolStripMenuItem";
            this.BackupToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.BackupToolStripMenuItem.Text = "Резервная копия";
            // 
            // CreateBackupToolStripMenuItem
            // 
            this.CreateBackupToolStripMenuItem.Name = "CreateBackupToolStripMenuItem";
            this.CreateBackupToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.CreateBackupToolStripMenuItem.Text = "Создать";
            this.CreateBackupToolStripMenuItem.Click += new System.EventHandler(this.CreateBackupToolStripMenuItem_Click);
            // 
            // LoadBackupToolStripMenuItem
            // 
            this.LoadBackupToolStripMenuItem.Name = "LoadBackupToolStripMenuItem";
            this.LoadBackupToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.LoadBackupToolStripMenuItem.Text = "Загрузить";
            this.LoadBackupToolStripMenuItem.Click += new System.EventHandler(this.LoadBackupToolStripMenuItem_Click);
            // 
            // SFD
            // 
            this.SFD.FileOk += new System.ComponentModel.CancelEventHandler(this.SFD_FileOk);
            // 
            // OFD
            // 
            this.OFD.FileName = "openFileDialog1";
            this.OFD.FileOk += new System.ComponentModel.CancelEventHandler(this.OFD_FileOk);
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 297);
            this.Controls.Add(this.PakingListButton);
            this.Controls.Add(this.report);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StartScreen";
            this.Text = "Программа";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StartScreen_FormClosing);
            this.Load += new System.EventHandler(this.StartScreen_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button report;
        private System.Windows.Forms.Button PakingListButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem работаСБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShipmentCreateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClientCreateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProviderCreateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProviderShipmentCreateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PurchaseHistoryCreateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShipmentUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClientUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProviderUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProviderShipmentUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PurchaseHistoryUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShipmentDeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClientDeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProviderDeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProviderShipmentDeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PurchaseHistoryDeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PackingListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CheckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BackupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateBackupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadBackupToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog SFD;
        private System.Windows.Forms.OpenFileDialog OFD;
    }
}

