namespace kursov_rabota
{
    partial class CreateScreen
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
            this.PurchaseHistoryDate = new System.Windows.Forms.DateTimePicker();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // PurchaseHistoryDate
            // 
            this.PurchaseHistoryDate.Location = new System.Drawing.Point(103, 168);
            this.PurchaseHistoryDate.MaxDate = new System.DateTime(2016, 4, 30, 11, 5, 33, 0);
            this.PurchaseHistoryDate.Name = "PurchaseHistoryDate";
            this.PurchaseHistoryDate.Size = new System.Drawing.Size(145, 20);
            this.PurchaseHistoryDate.TabIndex = 0;
            this.PurchaseHistoryDate.Value = new System.DateTime(2016, 4, 30, 0, 0, 0, 0);
            this.PurchaseHistoryDate.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(254, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 251);
            this.listBox1.TabIndex = 1;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(12, 12);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(119, 251);
            this.listBox2.TabIndex = 2;
            // 
            // CreateScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 277);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.PurchaseHistoryDate);
            this.Name = "CreateScreen";
            this.Text = "Экран создания";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateScreen_FormClosing);
            this.Load += new System.EventHandler(this.CreateScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker PurchaseHistoryDate;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
    }
}