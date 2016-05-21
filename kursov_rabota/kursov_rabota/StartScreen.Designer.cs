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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.работаСБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShipmentCreateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientCreateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProviderCreateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProviderShipmentCreateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PurchaseHistoryCreateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShipmentChangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientChangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProviderChangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProviderShipmentChangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PurchaseHistoryChangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.SuspendLayout();
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
            this.ChangeToolStripMenuItem,
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
            // 
            // ClientCreateToolStripMenuItem
            // 
            this.ClientCreateToolStripMenuItem.Name = "ClientCreateToolStripMenuItem";
            this.ClientCreateToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.ClientCreateToolStripMenuItem.Text = "Клиент";
            // 
            // ProviderCreateToolStripMenuItem
            // 
            this.ProviderCreateToolStripMenuItem.Name = "ProviderCreateToolStripMenuItem";
            this.ProviderCreateToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.ProviderCreateToolStripMenuItem.Text = "Поставщик";
            // 
            // ProviderShipmentCreateToolStripMenuItem
            // 
            this.ProviderShipmentCreateToolStripMenuItem.Name = "ProviderShipmentCreateToolStripMenuItem";
            this.ProviderShipmentCreateToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.ProviderShipmentCreateToolStripMenuItem.Text = "Поставщик-Товар";
            // 
            // PurchaseHistoryCreateToolStripMenuItem
            // 
            this.PurchaseHistoryCreateToolStripMenuItem.Name = "PurchaseHistoryCreateToolStripMenuItem";
            this.PurchaseHistoryCreateToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.PurchaseHistoryCreateToolStripMenuItem.Text = "История покупок";
            // 
            // ChangeToolStripMenuItem
            // 
            this.ChangeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShipmentChangeToolStripMenuItem,
            this.ClientChangeToolStripMenuItem,
            this.ProviderChangeToolStripMenuItem,
            this.ProviderShipmentChangeToolStripMenuItem,
            this.PurchaseHistoryChangeToolStripMenuItem});
            this.ChangeToolStripMenuItem.Name = "ChangeToolStripMenuItem";
            this.ChangeToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.ChangeToolStripMenuItem.Text = "Редактирование таблицы";
            // 
            // ShipmentChangeToolStripMenuItem
            // 
            this.ShipmentChangeToolStripMenuItem.Name = "ShipmentChangeToolStripMenuItem";
            this.ShipmentChangeToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.ShipmentChangeToolStripMenuItem.Text = "Товар";
            // 
            // ClientChangeToolStripMenuItem
            // 
            this.ClientChangeToolStripMenuItem.Name = "ClientChangeToolStripMenuItem";
            this.ClientChangeToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.ClientChangeToolStripMenuItem.Text = "Клиент";
            // 
            // ProviderChangeToolStripMenuItem
            // 
            this.ProviderChangeToolStripMenuItem.Name = "ProviderChangeToolStripMenuItem";
            this.ProviderChangeToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.ProviderChangeToolStripMenuItem.Text = "Поставщик";
            // 
            // ProviderShipmentChangeToolStripMenuItem
            // 
            this.ProviderShipmentChangeToolStripMenuItem.Name = "ProviderShipmentChangeToolStripMenuItem";
            this.ProviderShipmentChangeToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.ProviderShipmentChangeToolStripMenuItem.Text = "Поставщик-Товар";
            // 
            // PurchaseHistoryChangeToolStripMenuItem
            // 
            this.PurchaseHistoryChangeToolStripMenuItem.Name = "PurchaseHistoryChangeToolStripMenuItem";
            this.PurchaseHistoryChangeToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.PurchaseHistoryChangeToolStripMenuItem.Text = "История покупок";
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
            // 
            // ClientDeleteToolStripMenuItem
            // 
            this.ClientDeleteToolStripMenuItem.Name = "ClientDeleteToolStripMenuItem";
            this.ClientDeleteToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.ClientDeleteToolStripMenuItem.Text = "Клиент";
            // 
            // ProviderDeleteToolStripMenuItem
            // 
            this.ProviderDeleteToolStripMenuItem.Name = "ProviderDeleteToolStripMenuItem";
            this.ProviderDeleteToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.ProviderDeleteToolStripMenuItem.Text = "Поставщик";
            // 
            // ProviderShipmentDeleteToolStripMenuItem
            // 
            this.ProviderShipmentDeleteToolStripMenuItem.Name = "ProviderShipmentDeleteToolStripMenuItem";
            this.ProviderShipmentDeleteToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.ProviderShipmentDeleteToolStripMenuItem.Text = "Поставщик-Товар";
            // 
            // PurchaseHistoryDeleteToolStripMenuItem
            // 
            this.PurchaseHistoryDeleteToolStripMenuItem.Name = "PurchaseHistoryDeleteToolStripMenuItem";
            this.PurchaseHistoryDeleteToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.PurchaseHistoryDeleteToolStripMenuItem.Text = "История покупок";
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
            this.BackupToolStripMenuItem.Name = "BackupToolStripMenuItem";
            this.BackupToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.BackupToolStripMenuItem.Text = "Резервная копия";
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

        private System.Windows.Forms.Button backup;
        private System.Windows.Forms.Button report;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.Button deleteLine;
        private System.Windows.Forms.Button PakingListButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem работаСБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShipmentCreateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClientCreateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProviderCreateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProviderShipmentCreateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PurchaseHistoryCreateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShipmentChangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClientChangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProviderChangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProviderShipmentChangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PurchaseHistoryChangeToolStripMenuItem;
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
    }
}

