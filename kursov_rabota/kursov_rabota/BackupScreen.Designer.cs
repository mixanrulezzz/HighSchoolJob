namespace kursov_rabota
{
    partial class BackupScreen
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
            this.InBackup = new System.Windows.Forms.Button();
            this.OutBackup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InBackup
            // 
            this.InBackup.Location = new System.Drawing.Point(12, 12);
            this.InBackup.Name = "InBackup";
            this.InBackup.Size = new System.Drawing.Size(154, 23);
            this.InBackup.TabIndex = 0;
            this.InBackup.Text = "Создать резервную копию";
            this.InBackup.UseVisualStyleBackColor = true;
            this.InBackup.Click += new System.EventHandler(this.InBackup_Click);
            // 
            // OutBackup
            // 
            this.OutBackup.Location = new System.Drawing.Point(172, 12);
            this.OutBackup.Name = "OutBackup";
            this.OutBackup.Size = new System.Drawing.Size(177, 23);
            this.OutBackup.TabIndex = 1;
            this.OutBackup.Text = "Загрузить из резервной копии";
            this.OutBackup.UseVisualStyleBackColor = true;
            this.OutBackup.Click += new System.EventHandler(this.OutBackup_Click);
            // 
            // BackupScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 45);
            this.Controls.Add(this.OutBackup);
            this.Controls.Add(this.InBackup);
            this.Name = "BackupScreen";
            this.Text = "Резервная копия";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BackupScreen_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button InBackup;
        private System.Windows.Forms.Button OutBackup;
    }
}