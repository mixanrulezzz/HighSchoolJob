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
            this.FirstListBox = new System.Windows.Forms.ListBox();
            this.SecondListBox = new System.Windows.Forms.ListBox();
            this.IDLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.CreateButton = new System.Windows.Forms.Button();
            this.PhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.FirstListBoxLabel = new System.Windows.Forms.Label();
            this.SecondListBoxLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PurchaseHistoryDate
            // 
            this.PurchaseHistoryDate.Location = new System.Drawing.Point(138, 184);
            this.PurchaseHistoryDate.MaxDate = new System.DateTime(2016, 4, 30, 11, 5, 33, 0);
            this.PurchaseHistoryDate.Name = "PurchaseHistoryDate";
            this.PurchaseHistoryDate.Size = new System.Drawing.Size(233, 20);
            this.PurchaseHistoryDate.TabIndex = 5;
            this.PurchaseHistoryDate.Value = new System.DateTime(2016, 4, 30, 0, 0, 0, 0);
            this.PurchaseHistoryDate.Visible = false;
            // 
            // FirstListBox
            // 
            this.FirstListBox.FormattingEnabled = true;
            this.FirstListBox.Location = new System.Drawing.Point(377, 25);
            this.FirstListBox.Name = "FirstListBox";
            this.FirstListBox.Size = new System.Drawing.Size(120, 381);
            this.FirstListBox.TabIndex = 0;
            // 
            // SecondListBox
            // 
            this.SecondListBox.FormattingEnabled = true;
            this.SecondListBox.Location = new System.Drawing.Point(12, 25);
            this.SecondListBox.Name = "SecondListBox";
            this.SecondListBox.Size = new System.Drawing.Size(120, 381);
            this.SecondListBox.TabIndex = 6;
            this.SecondListBox.Visible = false;
            this.SecondListBox.SelectedIndexChanged += new System.EventHandler(this.SecondListBox_SelectedIndexChanged);
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(138, 12);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(18, 13);
            this.IDLabel.TabIndex = 3;
            this.IDLabel.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "label5";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(138, 28);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.ReadOnly = true;
            this.IDTextBox.Size = new System.Drawing.Size(233, 20);
            this.IDTextBox.TabIndex = 1;
            this.IDTextBox.Click += new System.EventHandler(this.IDTextBox_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(138, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(138, 106);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(233, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(138, 145);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(233, 20);
            this.textBox3.TabIndex = 4;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(296, 375);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(75, 23);
            this.CreateButton.TabIndex = 7;
            this.CreateButton.Text = "Создать";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // PhotoPictureBox
            // 
            this.PhotoPictureBox.Location = new System.Drawing.Point(211, 209);
            this.PhotoPictureBox.Name = "PhotoPictureBox";
            this.PhotoPictureBox.Size = new System.Drawing.Size(160, 160);
            this.PhotoPictureBox.TabIndex = 13;
            this.PhotoPictureBox.TabStop = false;
            // 
            // FirstListBoxLabel
            // 
            this.FirstListBoxLabel.AutoSize = true;
            this.FirstListBoxLabel.Location = new System.Drawing.Point(377, 6);
            this.FirstListBoxLabel.Name = "FirstListBoxLabel";
            this.FirstListBoxLabel.Size = new System.Drawing.Size(0, 13);
            this.FirstListBoxLabel.TabIndex = 14;
            // 
            // SecondListBoxLabel
            // 
            this.SecondListBoxLabel.AutoSize = true;
            this.SecondListBoxLabel.Location = new System.Drawing.Point(12, 6);
            this.SecondListBoxLabel.Name = "SecondListBoxLabel";
            this.SecondListBoxLabel.Size = new System.Drawing.Size(0, 13);
            this.SecondListBoxLabel.TabIndex = 15;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(141, 375);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 16;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // CreateScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 410);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SecondListBoxLabel);
            this.Controls.Add(this.FirstListBoxLabel);
            this.Controls.Add(this.PhotoPictureBox);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.SecondListBox);
            this.Controls.Add(this.FirstListBox);
            this.Controls.Add(this.PurchaseHistoryDate);
            this.Name = "CreateScreen";
            this.Text = "Экран создания";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateScreen_FormClosing);
            this.Load += new System.EventHandler(this.CreateScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker PurchaseHistoryDate;
        private System.Windows.Forms.ListBox FirstListBox;
        private System.Windows.Forms.ListBox SecondListBox;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.PictureBox PhotoPictureBox;
        private System.Windows.Forms.Label FirstListBoxLabel;
        private System.Windows.Forms.Label SecondListBoxLabel;
        private System.Windows.Forms.Button BackButton;
    }
}